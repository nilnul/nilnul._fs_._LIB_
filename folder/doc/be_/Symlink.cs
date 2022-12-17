using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.folder.doc.be_
{

	/// <summary>
	/// only judging the doc, not any ancestor
	/// </summary>
	/// <see cref="nilnul.fs.file.be_.link_.Sym"/>
	static public class _SymlinkX
	//: BeI
	{

		public static bool _Be_assumeParented(FileInfo directoryInfo) => directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);

		

		public static bool Be_ofAddress(string fullName)
		{
			return _Be_assumeParented(new FileInfo(fullName));
		}
		public static bool _Be(nilnul.fs.address_.spear_.based_.Child1 parentDir)
		{
			return Be_ofAddress(parentDir.ToString());
			
			//return Be(parentDir.parent, parentDir.child);
		}

		public static bool Be(nilnul.fs.address_.SpearI1 parentDir)
		{
			return Be_ofAddress(parentDir.ToString());
		}


		public static bool Be(FolderI parentDir, string dir)
		{
			return Be(
 nilnul.fs.address_.spear_.based_.Child1.Create_ofContainerAsAddress(
	parentDir.address.en.ToString(), dir
	)
			);

			//return nilnul.fs.folder.be_._SymlinkX.Be(
			//	new nilnul.fs.folder_.ParentDir(parentDir, dir)
			//);
		}

		public static bool Be(FileI parentDir)
		{
			return _Be_assumeParented(
				nilnul.fs.file.to_.ToFileInfo.Singleton.to(parentDir)
			);
		}

		public static bool Be(File parentDir)
		{
			return Be(
				(nilnul.fs.FileI)parentDir
			);
		}


		public static bool Be(Folder parentDir, string dir)
		{
			return Be((FolderI)parentDir, dir);
		}


		public static bool Be(DirectoryInfo directoryInfo, string dir) => Be(
			new nilnul.fs.address_.spear_.based_.Child1(directoryInfo, dir)
		);
		public static bool Be(nilnul.fs.address_.ShieldI parentDir, string dir)
		{
			return Be(new nilnul.fs.Folder(parentDir), dir);
		}


	}
}
