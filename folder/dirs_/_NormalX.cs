using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dirs_
{
	/// <summary>
	/// if the parent is link, this returns empty
	/// </summary>
	static public class _NonlinkX
	{
		static public IEnumerable<string> Captions(DirectoryInfo folder)
		{
			return folder.EnumerateDirectories().Where(x => nilnul.fs.folder.be_._NormalX.Be(x)).Select(x => x.Name);
		}


		static public IEnumerable<DirectoryInfo> Infos(DirectoryInfo parent)
		{
			return parent.EnumerateDirectories().Where(x => nilnul.fs.folder.be_._NormalX.Be(x));
		}

		static public IEnumerable<DirectoryInfo> Infos(nilnul.fs.FolderI parent)
		{
			return Infos(nilnul.fs.folder.to_.Info.Singleton.to(parent));
		}


		static public IEnumerable<string> Captions_ofAddress(string folderAddress)
		{
			return Captions(new DirectoryInfo(folderAddress));
		}


		//public static IEnumerable<nilnul.fs._address.DirI2> Enumerate(address_.Folder folder)
		//{
		//	return Captions_ofAddress(folder.ToString()).Where(x => nilnul.fs.folder.be_._NormalX.Be(x)).Select(x=>  nilnul.fs._address.Dir2.Parse(x));
		//}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.FolderI folder)
		{
			return  nilnul.fs.folder._DirsX.Dirs(folder).Where(
				x => nilnul.fs.folder.be_._NormalX.Be(
					new nilnul.fs.address_.shield_.BaseDir(
						folder.address.en
						,
						x
					)
				)
			);
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.address_.ShieldI folder)
		{
			return Dirs(new nilnul.fs.Folder(folder));
		}
		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofShield(string folder)
		{
			return Dirs(nilnul.fs.Folder.FroShield(folder));
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofAddress(string folder)
		{
			return Dirs_ofShield(nilnul.fs.address_.shield_._AddressX1.Txt(folder));
		}


		public static IEnumerable<string> Addresses(nilnul.fs.FolderI folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString()).Where(x => nilnul.fs.folder.be_._NormalX.Be(x));
		}

		public static IEnumerable<string> Addresses_ofShield(string folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder).Where(x => nilnul.fs.folder.be_._NormalX.Be_ofAddress(x));
		}

		public static IEnumerable<string> Addresses_ofAddress(string folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder).Where(x => nilnul.fs.folder.be_._NormalX.Be_ofAddress(x));
		}



		public static IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString()).Where(x => nilnul.fs.folder.be_._NormalX.Be(x)).Select(x => nilnul.fs.Folder.FroAddress(x));
		}






	}
}
