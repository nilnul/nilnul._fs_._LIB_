using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.folder.dir.be_
{
	static public class _AnySymX
	//: BeI
	{

		public static bool Be(FolderI parentDir, DirI dir)
		{
			return nilnul.fs.folder.be_.link_._SymX.Be(
				new nilnul.fs.folder_.ParentDir(parentDir, dir)
			);
		}

		public static bool Be(Folder parentDir, nilnul.fs._address.DirI dir)
		{
			return Be((FolderI)parentDir, dir);
		}
		public static bool Be(DirectoryInfo directoryInfo) =>
			nilnul.fs.folder.be_.link_._SymX.Be(directoryInfo);
		public static bool Be_ofAddress(string fullName)
		{
			return Be(new DirectoryInfo(fullName));
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


		public static bool Be(DirectoryInfo directoryInfo, nilnul.fs._address.DirI dir) => Be(
			new nilnul.fs.folder_.ParentDir(directoryInfo, dir)
		);
		public static bool Be(nilnul.fs.address_.ShieldI parentDir, nilnul.fs._address.DirI dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}

	}
}
