using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_.link_.sym
{
	/// <summary>
	/// in Shell, "dir" will return the relPath of the target.
	/// when cut and paster, relPath is kept.
	/// When copy, relPath is converted to realPath, as the newly-created folder is not symlink anymore, but a real folder.
	/// </summary>
	static public class _TgtX
	{
		[DllImport("kernel32.dll", EntryPoint = "CreateFileW", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, int dwShareMode, IntPtr securityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

		[DllImport("kernel32.dll", EntryPoint = "GetFinalPathNameByHandleW", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern int GetFinalPathNameByHandle([In] SafeFileHandle hFile, [Out] StringBuilder lpszFilePath, [In] int cchFilePath, [In] int dwFlags);

		private const int CREATION_DISPOSITION_OPEN_EXISTING = 3;
		private const int FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <returns>
		/// is this relative or absolute?
		/// </returns>
		public static string _Path_assumeLocation(string path)
		{
			path = nilnul.fs.address._OverlongX.PrependIfNeed(path);
			//if (!Directory.Exists(path) && !System.IO.File.Exists(path))
			//{
			//	throw new IOException("Path not found");
			//}

			SafeFileHandle pathHandle = CreateFile(path, 0, 2, IntPtr.Zero, CREATION_DISPOSITION_OPEN_EXISTING, FILE_FLAG_BACKUP_SEMANTICS, IntPtr.Zero); //Handle file / folder

			if (pathHandle.IsInvalid)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}

			StringBuilder result = new StringBuilder(512);
			int mResult = GetFinalPathNameByHandle(pathHandle, result, result.Capacity, 0);

			if (mResult < 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}

			if (result.Length >= 4 && result[0] == '\\' && result[1] == '\\' && result[2] == '?' && result[3] == '\\')
			{
				return result.ToString().Substring(4); // "\\?\" remove
			}
			return result.ToString();
		}
		public static string Path(nilnul.fs.ILocation location) {
			return _Path_assumeLocation(location.ToString());
		}


		public static string Path(string location) {
			return Path(nilnul.fs.LocationA.Location(location) );
		}

	}
}
