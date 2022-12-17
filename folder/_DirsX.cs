using nilnul.fs._address;
using nilnul.fs.folder_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	static public class _DirsX
	{
		static public IEnumerable<DirectoryInfo> Infos(DirectoryInfo parent)
		{
			return parent.EnumerateDirectories();
		}


		static public IEnumerable<string> Captions(nilnul.fs.AddressI folderAddress)
		{
			return Captions(new nilnul.fs.Folder(folderAddress));
		}
		static public IEnumerable<string> Captions(nilnul.fs.address_.ShieldI folderAddress)
		{
			return Captions(new nilnul.fs.Folder(folderAddress));
		}

		static public IEnumerable<string> Captions(nilnul.fs.Folder folderAddress)
		{
			return Captions((FolderI)(folderAddress));
		}

		public static IEnumerable<string> Captions(nilnul.fs.FolderI f)
		{
			return Captions(
				nilnul.fs.folder.to_._InfoX.To(f)
			);
		}

		static public IEnumerable<string> Captions_ofAddress(string folderAddress)
		{
			return Captions(new DirectoryInfo(folderAddress));
		}
		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<string> Captions(DirectoryInfo folder)
		{
			return nilnul.fs.folder._DirsX.Infos(folder) /*folder.EnumerateDirectories()*/.Select(x => x.Name);
		}

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.AddressI folder)
		{
			return Captions_ofAddress(folder.ToString()).Select(x => nilnul.fs._address.Dir.OvDenote(x));
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofAddress(string folder)
		{
			return Dirs( nilnul.fs.AddressA.Parse(folder));
		}


		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.FolderI folder)
		{
			return Captions_ofAddress(folder.ToString()).Select(
				x => nilnul.fs._address.Dir.OvDenote(x)
			);
		}
		public static IEnumerable<_address._route.division_._div.DirI> Dirs(nilnul.fs.FolderI1 folder)
		{
			return Captions_ofAddress(folder.ToString()).Select(
				x => nilnul.fs._address._route.division_._div.Dir.OfDnt(x)
			);
		}

		public static IEnumerable<DirI> Dirs(Folder dir)
		{
			return  Dirs( ( nilnul.fs.FolderI)(dir)  );
		}
		public static IEnumerable<_address._route.division_._div.DirI> Dirs(Folder1 dir)
		{
			return  Dirs( ( nilnul.fs.FolderI1)(dir)  );
		}

		public static IEnumerable<DirI> Dirs(nilnul.fs.address_.ShieldI dir)
		{
			return  Dirs( new nilnul.fs.Folder(dir)  );
		}

		[Obsolete()]
		public static IEnumerable<DirI> Dirs(DirectoryInfo dir)
		{
			return  Dirs( new nilnul.fs.Folder(dir)  );
		}
		public static IEnumerable<_address._route.division_._div.DirI> Dirs1(DirectoryInfo dir)
		{
			return  Dirs( new nilnul.fs.Folder1(dir)  );
		}

		public static IEnumerable<string> Addresses_ofAddress(string folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder);
			//throw new NotImplementedException();
		}

		static public IEnumerable<DirectoryInfo> Infos(
			nilnul.fs.FolderI parent
			)
		{
			return Infos(nilnul.fs.folder.to_.Info.Singleton.to(parent));
		}

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>


		public static IEnumerable<string> Addresses(nilnul.fs.FolderI folder)
		{
			return System.IO.Directory.EnumerateDirectories(folder.ToString());
		}

		public static IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			return Addresses(folder).Select(
				address => nilnul.fs.Folder.FroAddress(address)
			);
		}
		public static IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.address_.ShieldI folder)
		{
			return Folders(
				new nilnul.fs.Folder(folder)
			);
		}

		public static IEnumerable<nilnul.fs.FolderI> Folders_ofShield(string address)
		{
			return Folders(
				nilnul.fs.Folder.FroShield(address)
			);
		}


		public static IEnumerable<nilnul.fs.address_.ShieldI> _Shields_ofAddress(string address)
		{
			return Addresses_ofAddress(address).Select(x => nilnul.fs.address_.shield_._AddressX1.Create(x));
		}

		public static IEnumerable<nilnul.fs.address_.ShieldI> _Shields(nilnul.fs.address_.ShieldI shield)
		{
			return _Shields_ofAddress(shield.ToString());
		}

		public static IEnumerable<nilnul.fs.FolderI> Folders_ofAddress(string address)
		{
			return Folders_ofShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(address)
			);
		}





	}
}
