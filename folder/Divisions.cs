using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{

	static public class _DivisionsX
	{

		static public IEnumerable<_address.DivisionI> Divisions(nilnul.fs.FolderI folder)
		{
			foreach (var doc in nilnul.fs.folder._DocsX.Docs(folder) )
			{
				yield return new nilnul.fs._address.Document(  doc);

			}
			foreach (var dir in nilnul.fs.folder._DirsX.Dirs(folder))
			{
				foreach (var dirDivision in Divisions(  new nilnul.fs.folder_.ParentDir(folder, dir) ) )
				{
					yield return nilnul.fs._address.division_._DirDivisionX.Concat(dir, dirDivision);

				}
				yield return new _address.Div( dir);
			}

		}

		static public IEnumerable<System.IO.FileSystemInfo> FsInfoS(DirectoryInfo dir)
		{

			foreach (var item in dir.EnumerateDirectories())
			{
				foreach (var item1 in FsInfoS(item))
				{
					yield return item1;

				}
				yield return item;
			}
			foreach (var item in dir.EnumerateFiles())
			{
				yield return item;

			}
		}

		public static IEnumerable<_address.DivisionI> Divisions(AddressI ee)
		{
			return Divisions(
				new nilnul.fs.Folder(ee)
			);
		}

		public static IEnumerable<_address.DivisionI> Divisions_assumeShield(AddressI ee)
		{
			return Divisions(
				new nilnul.fs.Folder(
					nilnul.fs.address_.ShieldA.Ov_assumeShield(ee)
				)
			);
		}

		static public IEnumerable<System.IO.FileSystemInfo> FsInfoS(string dir)
		{

			return FsInfoS(new DirectoryInfo(dir));
		}
		static public IEnumerable<System.IO.FileSystemInfo> FsInfoS(nilnul.fs.FolderI dir)
		{

			return FsInfoS(nilnul.fs.folder.to_._InfoX.To(dir));
		}


		static public IEnumerable<nilnul.fs.File0FolderI> Locations(nilnul.fs.Folder dir)
		{
			return FsInfoS((DirectoryInfo)dir).Select(x => nilnul.fs.file0Folder_._InfoX.File0Folder(x));
		}
		static public IEnumerable<nilnul.fs.File0FolderI> Locations(nilnul.fs.FolderI dir)
		{
			return FsInfoS(dir).Select(x => nilnul.fs.file0Folder_._InfoX.File0Folder(x));
		}


		[Obsolete("folder shall end with separator")]
		static public IEnumerable<string> AddressesInTxts(string folder)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(folder))
			{
				foreach (var item1 in AddressesInTxts(item))
				{
					yield return item1;

				}
				yield return item;
			}

			foreach (var item in System.IO.Directory.EnumerateFiles(folder))
			{
				yield return item;

			}
		}

	}
}
