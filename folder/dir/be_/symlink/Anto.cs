using System.IO;

namespace nilnul.fs.folder.dir.be_.symlink
{
	static public class _AntoX
	//: BeI
	{
		public static bool _Be_assumeAddressAsParented(string parentedDir)
		{
			return !be_._SymlinkX.Be_ofAddress(parentedDir);
		}

		public static bool _Be_assumeParented(DirectoryInfo parentedDir)
		{
			return !be_._SymlinkX._Be_assumeParented(parentedDir);
		}


		public static bool Be(FolderI parentDir, nilnul.fs._address.DirI dir)
		{
			return !be_._SymlinkX.Be(parentDir, dir);
		}

		public static bool Be(Folder parentDir, nilnul.fs._address.DirI dir)
		{
			return Be((FolderI)parentDir, dir);
		}


		public static bool Be(DirectoryInfo directoryInfo, nilnul.fs._address.DirI dir) => Be(
			new nilnul.fs.Folder(directoryInfo), dir
		);

		public static bool Be(nilnul.fs.address_.ShieldI parentDir, nilnul.fs._address.DirI dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}

	}
}
