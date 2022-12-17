using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dirs_
{
	/// <summary>
	/// excluding dotLed dirs such as ".git", ".vs", ".nilnul"
	/// </summary>
	static public class _NotDotLedX
	{
		

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.FolderI folder)
		{
			return  nilnul.fs.folder._DirsX.Dirs(folder).Where(
				 nilnul.fs._address.dir.be_.dotLed.Anto.Singleton.be
			);
		}
		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.Folder folder)
		{
			return Dirs((FolderI)(folder));
		}
		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.address_.ShieldI folder)
		{
			return Dirs(new nilnul.fs.Folder(folder));
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofShield(string folder)
		{
			return Dirs(nilnul.fs.Folder.FroShield(folder));
		}

		static public IEnumerable<_address.DirI> Dirs(DirectoryInfo folder)
		{
			return Dirs(new nilnul.fs.Folder(folder) );
		}
		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofAddress(string folder)
		{
			return Dirs_ofShield(nilnul.fs.address_.shield_._AddressX1.Txt(folder));
		}


		static public IEnumerable<string> Captions(DirectoryInfo folder)
		{
			return Dirs(folder ).Select(d=>d.denote.en);
		}

		static public IEnumerable<string> Captions_ofAddress(string folderAddress)
		{
			return Captions(new DirectoryInfo(folderAddress));
		}

		static public IEnumerable<DirectoryInfo> Infos(nilnul.fs.FolderI parent)
		{
			return Dirs(parent).Select(
				d=> nilnul.fs.address_.shield.to_._InfoX.Info(
					new nilnul.fs.address_.shield_.BaseDir(parent.address.en,d)
				)
			);

		}
		public static IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			return Infos(folder).Select( f=> new nilnul.fs.Folder(f));
		}
		static public IEnumerable<DirectoryInfo> Infos(nilnul.fs.Folder parent)
		{
			return  Infos(( nilnul.fs.FolderI)(parent));
		}

		static public IEnumerable<DirectoryInfo> Infos(DirectoryInfo parent)
		{
			return  Infos(new nilnul.fs.Folder(parent));
		}










		public static IEnumerable<string> Addresses(nilnul.fs.FolderI folder)
		{
			return Infos(folder).Select(x=>x.FullName);
		}

		public static IEnumerable<string> Addresses_ofShield(string folder)
		{
			return Addresses(nilnul.fs.Folder.FroShield(folder) );
		}

		public static IEnumerable<string> Addresses_ofAddress(string folder)
		{
			return Addresses(nilnul.fs.Folder.FroAddress(folder) );
		}








	}
}
