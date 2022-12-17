using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.folder.div.be_
{
	static public class _AnySymX
	//: BeI
	{
		public static bool Be(FolderI parentDir, DivI div)
		{
			var newBase = parentDir;
			foreach (var dir1 in div.dirs)
			{
				if (nilnul.fs.folder.dir.be_._SymlinkX.Be(newBase, dir1))
				{
					return true;
				}
				newBase = new nilnul.fs.folder_.ParentDir(newBase, dir1);

			}
			return false;
		}

		public static bool Be(Folder parentDir, nilnul.fs._address.DivI div)
		{
			return Be((FolderI)parentDir, div);
		}

		public static bool Be(DirectoryInfo directoryInfo, nilnul.fs._address.DivI div) => Be(
			new nilnul.fs.Folder(directoryInfo)
			,
			div
		);
		public static bool Be(nilnul.fs.address_.ShieldI parentDir, nilnul.fs._address.DivI dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}

		public static bool Be(nilnul.fs.AddressI parentDir, nilnul.fs._address.DivI dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}


	}
}
