using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.fs.folder
{
	public class Dirs
	{
		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<string> Enumerate(DirectoryInfo folder) {
			return folder.EnumerateDirectories().Select(x=>x.Name);
		}

		[Obsolete(nameof(dirs.as_._ChildsX))]
		static public IEnumerable<DirectoryInfo> AsDirectoryInfoS(DirectoryInfo parent) {
			return parent.EnumerateDirectories();
		}

		[Obsolete(nameof(dirs.as_._ChildsX))]

		static public IEnumerable<DirectoryInfo> AsDirectoryInfoS(nilnul.fs.Folder parent) {
			return AsDirectoryInfoS((DirectoryInfo)parent);
		}

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		static public IEnumerable<string> Enumerate(string  folderAddress) {
			return Enumerate(new DirectoryInfo(folderAddress));
		}

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		static public IEnumerable<string> OfAddress(string  folderAddress) {
			return Enumerate(new DirectoryInfo(folderAddress));
		}

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.Dir> Enumerate(address_.Folder folder)
		{
			return Enumerate(folder.ToString()).Select(x=>  nilnul.fs._address.Dir.Parse(x));
		}
		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.Dir> Enumerate(nilnul.fs.FolderI1 folder)
		{
			return Enumerate(folder.ToString()).Select(x=>  nilnul.fs._address.Dir.Parse(x));
		}

		[Obsolete()]
		public static IEnumerable<string> EnumerateAsAddress(nilnul.fs.FolderI1 folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString());
		}




	}
}
