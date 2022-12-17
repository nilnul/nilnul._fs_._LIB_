using System.IO;
using System.Linq;

namespace nilnul.fs.folder.be_.link_
{
	/// <summary>
	/// any dir is link
	/// </summary>
	//[Obsolete("only taken into account of the last dir")]
	static public class _SymX
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
		public static bool Be(nilnul.fs.address_.ShieldI directoryInfo)
		{
			return Be(new nilnul.fs.Folder(directoryInfo));
		}

		//public static bool Be(DirectoryInfo directoryInfo) => directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);

		public static bool Be_ofAddress(string fullName)
		{
			return Be(new DirectoryInfo(fullName));
		}


	}

	public class Sym : nilnul.fs.folder.BeI
	{
		public bool be(FolderI obj)
		{
			return _SymX.Be(obj);
		}


		static public Sym Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sym>.Instance;
			}
		}

	}
}
