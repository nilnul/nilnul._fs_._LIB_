using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace nilnul.fs.location_.link_._sym_
{
	[Obsolete()]

	internal static class SymbolicLink
	{
		private const uint GENERIC_READ_ACCESS = 0x80000000;

		private const uint FileFlagsForOpenReparsePointAndBackupSemantics = 0x02200000;

		private const int IoctlCommandGetReparsePoint = 0x000900A8;

		private const uint OpenExisting = 0x3;

		private const uint PathNotAReparsePointError = 0x80071126;

		private const uint ShareModeAll = 0x7; // Read, Write, Delete

		private const uint SymLinkTag = 0xA000000C;

		private const int TargetIsAFile = 0;

		private const int TargetIsADirectory = 1;

		/// <summary>
		/// Creates or opens a file or I/O device.
		/// </summary>
		/// <param name="lpFileName">The name of the file or device to be created or opened. You may use either forward slashes (/) or backslashes (\) in this name.
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.
		/// For information on special device names, see Defining an MS-DOS Device Name.
		/// To create a file stream, specify the name of the file, a colon, and then the name of the stream.For more information, see File Streams.
		/// Tip Starting with Windows 10, version 1607, for the unicode version of this function (CreateFileW), you can opt-in to remove the MAX_PATH limitation without prepending "\\?\". See the "Maximum Path Length Limitation" section of Naming Files, Paths, and Namespaces for details.</param>
		/// <param name="dwDesiredAccess"></param>
		/// <param name="dwShareMode"></param>
		/// <param name="lpSecurityAttributes"></param>
		/// <param name="dwCreationDisposition"></param>
		/// <param name="dwFlagsAndAttributes"></param>
		/// <param name="hTemplateFile">A valid handle to a template file with the GENERIC_READ access right. The template file supplies file attributes and extended attributes for the file that is being created.
		/// This parameter can be NULL.
		/// When opening an existing file, CreateFile ignores this parameter.
		/// When opening a new encrypted file, the file inherits the discretionary access control list from its parent directory.For additional information, see File Encryption.
		/// </param>
		/// <returns>When an application is finished using the object handle returned by CreateFile, use the CloseHandle function to close the handle. This not only frees up system resources, but can have wider influence on things like sharing the file or device and committing data to disk. Specifics are noted within this topic as appropriate.
		/// </returns>
		/// <remarks>
		/// An application cannot create a directory by using CreateFile, therefore only the OPEN_EXISTING value is valid for dwCreationDisposition for this use case. To create a directory, the application must call CreateDirectory or CreateDirectoryEx.
		/// To open a directory using CreateFile, specify the FILE_FLAG_BACKUP_SEMANTICS flag as part of dwFlagsAndAttributes.Appropriate security checks still apply when this flag is used without SE_BACKUP_NAME and SE_RESTORE_NAME privileges.
		/// </remarks>
		[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		private static extern SafeFileHandle CreateFile(
			string lpFileName,
			uint dwDesiredAccess,
			uint dwShareMode,
			IntPtr lpSecurityAttributes,
			uint dwCreationDisposition,
			uint dwFlagsAndAttributes,
			IntPtr hTemplateFile
		);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern SafeFileHandle CreateFileW(
			string lpFileName,
			uint dwDesiredAccess,
			uint dwShareMode,
			IntPtr lpSecurityAttributes,
			uint dwCreationDisposition,
			uint dwFlagsAndAttributes,
			IntPtr hTemplateFile
		);


		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern bool DeviceIoControl(
			IntPtr hDevice,
			uint dwIoControlCode,
			IntPtr lpInBuffer,
			int nInBufferSize,
			IntPtr lpOutBuffer,
			int nOutBufferSize,
			out int lpBytesReturned,
			IntPtr lpOverlapped
		);

		public static void CreateDirectoryLink(string linkPath, string targetPath)
		{
			if (!CreateSymbolicLink(linkPath, targetPath, TargetIsADirectory) || Marshal.GetLastWin32Error() != 0)
			{
				try
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				catch (COMException exception)
				{
					throw new IOException(exception.Message, exception);
				}
			}
		}

		[Obsolete("poosible exception")]

		public static void CreateFileLink(string linkPath, string targetPath)
		{
			if (!CreateSymbolicLink(linkPath, targetPath, TargetIsAFile))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
		}

		public static bool Exists(string path)
		{
			if (!Directory.Exists(path) && !System.IO.File.Exists(path))
			{
				return false;
			}
			string target = GetTarget(path);
			return target != null;
		}

		private static SafeFileHandle GetFileHandle(string path)
		{
			return CreateFile(path, GENERIC_READ_ACCESS, ShareModeAll, IntPtr.Zero, OpenExisting,
				FileFlagsForOpenReparsePointAndBackupSemantics, IntPtr.Zero);
		}
		private static SafeFileHandle GetFileHandleW(string path)
		{
			return CreateFileW(path, GENERIC_READ_ACCESS, ShareModeAll, IntPtr.Zero, OpenExisting,
				FileFlagsForOpenReparsePointAndBackupSemantics, IntPtr.Zero);
		}

		public static string GetTarget(string path)
		{
			SymbolicLinkReparseData reparseDataBuffer;

			using (SafeFileHandle fileHandle = GetFileHandle(path))
			{
				if (fileHandle.IsInvalid)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
#if NET35
                int outBufferSize = Marshal.SizeOf(typeof(SymbolicLinkReparseData));
#else
				int outBufferSize = Marshal.SizeOf<SymbolicLinkReparseData>();
#endif
				IntPtr outBuffer = IntPtr.Zero;
				try
				{
					outBuffer = Marshal.AllocHGlobal(outBufferSize);
					int bytesReturned;
					bool success = DeviceIoControl(
						fileHandle.DangerousGetHandle(), IoctlCommandGetReparsePoint, IntPtr.Zero, 0,
						outBuffer, outBufferSize, out bytesReturned, IntPtr.Zero
					);

					fileHandle.Dispose();

					if (!success)
					{
						if (((uint)Marshal.GetHRForLastWin32Error()) == PathNotAReparsePointError)
						{
							return null;
						}
						Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
					}

#if NET35
                    reparseDataBuffer = (SymbolicLinkReparseData)Marshal.PtrToStructure(
                        outBuffer, typeof(SymbolicLinkReparseData));
#else
					reparseDataBuffer = Marshal.PtrToStructure<SymbolicLinkReparseData>(outBuffer);
#endif
				}
				finally
				{
					Marshal.FreeHGlobal(outBuffer);
				}
			}
			if (reparseDataBuffer.ReparseTag != SymLinkTag)
			{
				return null;
			}

			string target = Encoding.Unicode.GetString(reparseDataBuffer.PathBuffer,
				reparseDataBuffer.PrintNameOffset, reparseDataBuffer.PrintNameLength);

			return target;
		}
		public static string GetTargetW(string path)
		{
			SymbolicLinkReparseData reparseDataBuffer;

			using (SafeFileHandle fileHandle = GetFileHandleW(path))
			{
				if (fileHandle.IsInvalid)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
#if NET35
                int outBufferSize = Marshal.SizeOf(typeof(SymbolicLinkReparseData));
#else
				int outBufferSize = Marshal.SizeOf<SymbolicLinkReparseData>();
#endif
				IntPtr outBuffer = IntPtr.Zero;
				try
				{
					outBuffer = Marshal.AllocHGlobal(outBufferSize);
					int bytesReturned;
					bool success = DeviceIoControl(
						fileHandle.DangerousGetHandle(), IoctlCommandGetReparsePoint, IntPtr.Zero, 0,
						outBuffer, outBufferSize, out bytesReturned, IntPtr.Zero
					);

					fileHandle.Dispose();

					if (!success)
					{
						if (((uint)Marshal.GetHRForLastWin32Error()) == PathNotAReparsePointError)
						{
							return null;
						}
						Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
					}

#if NET35
                    reparseDataBuffer = (SymbolicLinkReparseData)Marshal.PtrToStructure(
                        outBuffer, typeof(SymbolicLinkReparseData));
#else
					reparseDataBuffer = Marshal.PtrToStructure<SymbolicLinkReparseData>(outBuffer);
#endif
				}
				finally
				{
					Marshal.FreeHGlobal(outBuffer);
				}
			}
			if (reparseDataBuffer.ReparseTag != SymLinkTag)
			{
				return null;
			}

			string target = Encoding.Unicode.GetString(reparseDataBuffer.PathBuffer,
				reparseDataBuffer.PrintNameOffset, reparseDataBuffer.PrintNameLength);

			return target;
		}

	}
}