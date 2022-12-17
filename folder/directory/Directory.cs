using nilnul.fs._address;
using nilnul.fs.folder_;
using System;

namespace nilnul.fs.folder.directory
{
	static public class _CreateX
	{
		static public nilnul.fs.Folder CreateFroContainerDirectory(
			nilnul.fs.FolderI1 container,

			nilnul.fs._address._route.division_._div.dir.str_.Started dir
		)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder1 CreateFroContainerDirectory(
			nilnul.fs.FolderI1 container,

			nilnul.fs._address._route.division_.div_.DirectoryI dir
		)

		{
			return folder._CreateX._Folder_ofAddress1(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder1 CreateFroContainerDirectory(
			nilnul.fs.FolderI1 container,

			nilnul.fs._address._route.division_.div_.Directory dir
		)

		{
			return folder._CreateX._Folder_ofAddress1(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		public static void CreateFroContainerDirectory(
			nilnul.fs.FolderI1 empty
			,
			_address._route.division_. DestinationI key
		)
		{
			CreateFroContainerDirectory(empty, _address._route.division_.div_.Directory.Of(key) );
		}
		static public nilnul.fs.Folder1 CreateFroContainerDirectory(
			nilnul.fs.Folder1 container,

			nilnul.fs._address._route.division_._div.dir.str_.Started dir
		)

		{
			return folder._CreateX._Folder_ofAddress1(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder1 CreateFroContainerDirectory(nilnul.fs.Folder1 container,

			string dir)

		{
			return folder._CreateX._Folder_ofAddress1(System.IO.Path.Combine(container.ToString(), dir));
		}

	}
}
