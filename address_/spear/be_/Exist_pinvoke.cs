using System;
using System.IO;
using System.Runtime.InteropServices;

namespace nilnul.fs.address_.spear.be_
{
	/*System.IO.PathTooLongException: The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters. at System.IO.Path.NormalizePathFast(String path, Boolean fullCheck) at System.IO.Path.GetFullPathInternal(String path) at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy) at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options) at System.IO.File.Create(String path)*/
	/// <summary>
	/// todo: not tested
	/// </summary>
	///
	[Obsolete("not tested", true)]
	static public class _LocationX_pinvoke
	{
		

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		static extern uint GetFileAttributes(string lpFileName);

		public static bool DirectoryExists(string path)
		{
			uint attributes = GetFileAttributes(path.StartsWith(@"\\?\") ? path : @"\\?\" + path);
			if (attributes != 0xFFFFFFFF)
			{
				return ((FileAttributes)attributes).HasFlag(FileAttributes.Directory);
			}
			else
			{
				return false;
			}
		}

		public static bool FileExists(string path)
		{
			uint attributes = GetFileAttributes(path.StartsWith(@"\\?\") ? path : @"\\?\" + path);
			if (attributes != 0xFFFFFFFF)
			{
				return !((FileAttributes)attributes).HasFlag(FileAttributes.Directory);
			}
			else
			{
				return false;
			}
		}
	}

	
}
