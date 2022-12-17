using System.IO;
using System.Linq;

namespace nilnul.fs.folder.be_.link_.sym_
{
	//[Obsolete("only taken into account of the last dir")]
	static public class _TipX
	//: BeI
	{
		public static bool Be(DirectoryInfo directoryInfo) => directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);

		static public bool Be(nilnul.fs.FolderI folder)
		{
			return Be( nilnul.fs.folder.to_._InfoX.To(folder) );
		}

		public static bool Be_ofAddress(string fullName)
		{
			return Be(new DirectoryInfo(fullName));
		}
		static public bool Be(nilnul.fs.Folder folder)
		{
			return Be((nilnul.fs.FolderI)folder);
		}
		public static bool Be(nilnul.fs.address_.ShieldI directoryInfo)
		{
			return Be(nilnul.fs.address_.shield.to_._InfoX.Info(directoryInfo));
		}



	}

	public class Tip : nilnul.fs.folder.BeI
	{
		public bool be(FolderI obj)
		{
			return _TipX.Be(obj);
		}



		static public Tip Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Tip>.Instance;
			}
		}


	}
}
