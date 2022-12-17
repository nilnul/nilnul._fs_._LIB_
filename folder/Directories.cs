using nilnul.bit.combine_;
using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	static public class _DirectoriesX
	{
		public static IEnumerable<_address.Directory> Directories(FolderI folder)
		{
			return nilnul.fs.folder._DirsX.Dirs(folder).SelectMany(

				dir1 => _DivsX1.Divs(
					new nilnul.fs.address_.shield_.BaseDir(
						folder.address.en, 
						dir1
					)
				).Select(

					div => new _address.Directory(dir1,div.dirs)

				)
			);


		}
		static public IEnumerable<_address.Directory> Directories(DirectoryInfo folder)
		=>
			nilnul.fs.folder._DirsX.Dirs(folder).SelectMany(

				dir1 => _DivsX1.Divs(
					new nilnul.fs.address_.shield_.BaseDir(
						folder, 
						dir1
					)
				).Select(

					div => new _address.Directory(dir1,div.dirs)

				)
			);


		static public IEnumerable<DirectoryInfo> Infos(DirectoryInfo dir)
		=>
			dir.EnumerateDirectories().SelectMany(dir1 => _DivsX1.Infos(dir1));


		static public IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI dir)
		=> _DirsX.Infos(dir).SelectMany(info => _DivsX1.Folders(info));



		static public IEnumerable<string> Addresses_ofAddress(string folder)
		=> _DirsX.Addresses_ofAddress(folder).SelectMany(info => _DivsX1.Addresses_ofAddress(info));
	}
}