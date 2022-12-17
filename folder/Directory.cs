using nilnul.fs._address;
using nilnul.fs.folder_;
using System;

namespace nilnul.fs.folder
{
	public class Directory
	{
		static public nilnul.fs.Folder CreateFroContainerDirectory(
			nilnul.fs.FolderI container,

			nilnul.fs._address.dir.str_.seq.Started dir
		)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder CreateFroContainerDirectory(
			nilnul.fs.FolderI container,

			nilnul.fs._address.DirectoryI dir
		)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder CreateFroContainerDirectory(
			nilnul.fs.FolderI container,

			nilnul.fs._address.Directory dir
		)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		public static void CreateFroContainerDirectory(nilnul.fs.FolderI empty, DestinationI key)
		{
			CreateFroContainerDirectory(empty, _address.Directory.Ov(key) );
		}
		static public nilnul.fs.Folder CreateFroContainerDirectory(
			nilnul.fs.Folder container,

			nilnul.fs._address.dir.str_.seq.Started dir
		)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir.ToString()));
		}

		static public nilnul.fs.Folder CreateFroContainerDirectory(nilnul.fs.Folder container,

			string dir)

		{
			return folder._CreateX._Folder_ofAddress(System.IO.Path.Combine(container.ToString(), dir));
		}

	}
}
