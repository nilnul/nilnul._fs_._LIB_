using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.fs.folder.dirs_
{
	[Obsolete()]
	static public class _NormalX
	{
		static public IEnumerable<string> Enumerate(DirectoryInfo folder) {
			return folder.EnumerateDirectories().Where(x=> nilnul.fs.folder.be_._NormalX.Be(x) ).Select(x=>x.Name);
		}

		static public IEnumerable<DirectoryInfo> AsDirectoryInfoS(DirectoryInfo parent) {
			return parent.EnumerateDirectories().Where(x => nilnul.fs.folder.be_._NormalX.Be(x));
		}

		static public IEnumerable<DirectoryInfo> AsDirectoryInfoS(nilnul.fs.Folder1 parent) {
			return AsDirectoryInfoS((DirectoryInfo)parent);
		}


		static public IEnumerable<string> Enumerate(string  folderAddress) {
			return Enumerate(new DirectoryInfo(folderAddress));
		}


		public static IEnumerable<nilnul.fs._address.DirI2> Enumerate(address_.Folder folder)
		{
			return Enumerate(folder.ToString()).Where(x => nilnul.fs.folder.be_._NormalX.Be(x)).Select(x=>  nilnul.fs._address.Dir2.Parse(x));
		}

		public static IEnumerable<nilnul.fs._address.DirI2> Enumerate(nilnul.fs.FolderI1 folder)
		{
			return Enumerate(folder.ToString()).Where(x => nilnul.fs.folder.be_._NormalX.Be(x)).Select(x=>  nilnul.fs._address.Dir2.Parse(x));
		}

		public static IEnumerable<string> EnumerateAsAddress(nilnul.fs.FolderI1 folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString()).Where(x=> nilnul.fs.folder.be_._NormalX.Be(x) );
		}




	}
}
