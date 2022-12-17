using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using nilnul.fs.location_._symlink;

namespace nilnul.fs.location_
{
	namespace _symlink
	{
		[Obsolete()]
	enum FileOrFolder
		{
			File = 0,
			Directory = 1
		}
	}


	/// <summary>
	/// 	that point to a file or folder on your system
	/// </summary>
	/* Microsoft Windows shortcuts normally refer to a destination by an absolute path (starting from the root directory), whereas POSIX symbolic links can refer to destinations via either an absolute or a relative path. The latter is useful if both the location and destination of the symbolic link share a common path prefix, but that prefix is not yet known when the symbolic link is created (e.g., in an archive file that can be unpacked anywhere).
	Microsoft Windows application shortcuts contain additional metadata that can be associated with the destination, whereas POSIX symbolic links are just strings that will be interpreted as absolute or relative pathnames.
	*/

	[Obsolete()]

	public class Symlink
	{
		//[DllImport("kernel32.dll", SetLastError = true)]
		[DllImport("kernel32.dll")]
		static extern bool CreateSymbolicLink(
		string lpSymlinkFileName, string lpTargetFileName, FileOrFolder dwFlags);

		static public bool CreateFile(nilnul.fs.address_.SpearI1 fileName, nilnul.fs.Address symbolicLink)
		{

			//string symbolicLink = @"c:\bar.txt";
			//string fileName = @"c:\temp\foo.txt";

			return CreateSymbolicLink(symbolicLink.ToString(), fileName.ToString(), FileOrFolder.File);
		}

		static public bool CreateFile(string fileName, string symbolicLink) {
			return CreateFile(
				 nilnul.fs.address_.Spear1.Parse(fileName)
				,
				new Address(symbolicLink)
				
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="target"></param>
		/// <param name="symbolicLink"></param>
		/// <exception cref="">
		/// visual studio has to be run as admin to make this work.
		/// </exception>
		static public void CreateFile_throwIfFail(string target, string symbolicLink) {
			nilnul.obj.vow_.True.Vow( CreateFile(
				nilnul.fs.address_.Spear1.Parse(target)
				,
				new Address(symbolicLink)
				
			));
		}


	}
}
