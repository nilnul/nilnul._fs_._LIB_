using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dirs.as_
{
	static public class _ChildsX
	{
		static public IEnumerable<string> AddressTxtS(DirectoryInfo folder)
		{
			return folder.EnumerateDirectories().Select(x => x.FullName);
		}

		static public IEnumerable<DirectoryInfo> DirectoryInfoS(DirectoryInfo parent)
		{
			return parent.EnumerateDirectories();
		}

		static public IEnumerable<DirectoryInfo> DirectoryInfoS(nilnul.fs.Folder parent)
		{
			return DirectoryInfoS((DirectoryInfo)parent);
		}


		static public IEnumerable<string> AddressTxtS(string folderAddress)
		{
			return AddressTxtS(new DirectoryInfo(folderAddress));
		}







		public static IEnumerable<string> AddressTxtS(nilnul.fs.FolderI folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString());
		}




	}
}
