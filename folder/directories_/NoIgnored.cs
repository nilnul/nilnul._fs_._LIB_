using nilnul.bit.combine_;
using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.directories_
{
	static public class _UnignoredX
	{
		public static IEnumerable<_address.Directory> Directories(FolderI folder, _address.DocI ignoreDoc)
		{
			return nilnul.fs.folder.dirs_._UnignoredX.Dirs(folder, ignoreDoc).SelectMany(
				dir => fs.folder.divs_._Self0UnignoredX.Divs(
					new nilnul.fs.folder_.ParentDir(
						folder.address.en, dir
					)
					,
					ignoreDoc
				).Select(
					div => _address.directory_._DirDivX.Directory(dir, div)
				)
			);



		}
		static public IEnumerable<_address.Directory> Directories(DirectoryInfo folder, _address.DocI ignoreDoc)
		=> Directories(new nilnul.fs.Folder(folder), ignoreDoc);
		static public IEnumerable<_address.Directory> Directories(nilnul.fs.Folder folder, _address.DocI ignoreDoc)
		=> Directories((FolderI)(folder), ignoreDoc);


	}
}