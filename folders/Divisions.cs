using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folders
{

	static public class _DivisionsX
	{
		static public IEnumerable<FileSystemInfo> FsInfoS(IEnumerable<DirectoryInfo> dirs)
		{
			return dirs.SelectMany(
				x => nilnul.fs.folder._DivisionsX.FsInfoS(x)
			);
		}

		static public IEnumerable<FileSystemInfo> FsInfoS(IEnumerable<string> dirs)
		{
			return dirs.SelectMany(
				x => nilnul.fs.folder._DivisionsX.FsInfoS(x)
			);
		}


		static public IEnumerable<FileSystemInfo> FsInfoS(params string[] dirs)
		{
			return FsInfoS(dirs as IEnumerable<string>);
		}


		static public IEnumerable<string> AddressesInTxts(IEnumerable<string> folders)
		{
			return folders.SelectMany(
#pragma warning disable CS0618 // '_DivisionsX.AddressesInTxts(string)' is obsolete: 'folder shall end with separator'
				x => nilnul.fs.folder._DivisionsX.AddressesInTxts(x)
#pragma warning restore CS0618 // '_DivisionsX.AddressesInTxts(string)' is obsolete: 'folder shall end with separator'
			);

		}

		public static IEnumerable<nilnul.fs._location_.BlankI> Locations(IEnumerable<Folder> dirs)
		{
			return dirs.SelectMany(
				x => nilnul.fs.folder._DivisionsX.Locations(x)
			);

			throw new NotImplementedException();
		}
	}
}
