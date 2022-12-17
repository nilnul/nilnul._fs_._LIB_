using nilnul.bit.combine_;
using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.directories_
{
	static public class _NoDotLedX
	{
		public static IEnumerable<_address.Directory> Directories(FolderI folder)
		{
			return nilnul.fs.folder.dirs_._NotDotLedX.Dirs(folder).SelectMany(
				dir => fs.folder.divs_._Self0NoDotLedX.Divs(
					new nilnul.fs.folder_.ParentDir(
						folder.address.en,
						dir
					)
					
				).Select(
					div => _address.directory_._DirDivX.Directory(dir, div)
				)
			);



		}
		static public IEnumerable<_address.Directory> Directories(
			nilnul.fs.Folder folder
		)
		=> Directories(
			(FolderI)(folder)
		);
		static public IEnumerable<_address.Directory> Directories(
			DirectoryInfo folder
		)
		=> Directories(new nilnul.fs.Folder(folder));


	}
}