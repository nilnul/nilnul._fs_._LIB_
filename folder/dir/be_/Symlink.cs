using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.folder.dir.be_
{

	/// <summary>
	/// only judging the dir, not any ancestor
	/// </summary>
	static public class _SymlinkX
	//: BeI
	{

		public static bool _Be_assumeParented(DirectoryInfo directoryInfo) => directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);

		[Obsolete(nameof(_Be_assumeParented))]
		public static bool Be(DirectoryInfo directoryInfo) => _Be_assumeParented(directoryInfo);

		public static bool Be_ofAddress(string fullName)
		{
			return Be(new DirectoryInfo(fullName));
		}
		public static bool _Be(nilnul.fs.address_.shield_.BaseDir parentDir)
		{
			return Be_ofAddress(parentDir.ToString());
			
			//return Be(parentDir.parent, parentDir.child);
		}

		public static bool Be(nilnul.fs.folder_.ParentDir parentDir)
		{
			return _Be(parentDir.en);
		}


		public static bool Be(FolderI parentDir, DirI dir)
		{
			return Be(
new nilnul.fs.folder_.ParentDir(parentDir, dir)
			);

			//return nilnul.fs.folder.be_._SymlinkX.Be(
			//	new nilnul.fs.folder_.ParentDir(parentDir, dir)
			//);
		}

		public static bool Be(FolderI parentDir)
		{
			return Be(
				nilnul.fs.folder.to_.Info.Singleton.to(parentDir)
			);
		}

		public static bool Be(Folder parentDir)
		{
			return Be(
				(nilnul.fs.FolderI)parentDir
			);
		}


		public static bool Be(Folder parentDir, nilnul.fs._address.DirI dir)
		{
			return Be((FolderI)parentDir, dir);
		}


		public static bool Be(DirectoryInfo directoryInfo, nilnul.fs._address.DirI dir) => Be(
			new nilnul.fs.folder_.ParentDir(directoryInfo, dir)
		);
		public static bool Be(nilnul.fs.address_.ShieldI parentDir, nilnul.fs._address.DirI dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}


	}
}
