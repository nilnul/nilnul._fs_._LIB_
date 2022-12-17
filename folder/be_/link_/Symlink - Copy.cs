using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// any dir is link
	/// </summary>
	[Obsolete(nameof(folder.be_.link_._SymX))]
	static public class _SymlinkX
	//: BeI
	{
		static public bool Be(nilnul.fs.FolderI folder)
		{
			return nilnul.fs.folder._ProgenitorsX.Folders(folder).Any(x => nilnul.fs.folder.dir.be_._SymlinkX.Be(x));
		}

		static public bool Be(nilnul.fs.Folder folder)
		{
			return Be((nilnul.fs.FolderI)folder);
		}
		public static bool Be(DirectoryInfo directoryInfo)
		{
			return Be(new nilnul.fs.Folder(directoryInfo));
		}
		//public static bool Be(DirectoryInfo directoryInfo) => directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);

		public static bool Be_ofAddress(string fullName)
		{
			return Be(new DirectoryInfo(fullName));
		}

	}
}
