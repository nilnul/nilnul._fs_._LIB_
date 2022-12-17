using System.IO;

namespace nilnul.fs.folder._dir
{
	static public class _EnsureX
	{

		static public void Void(nilnul.fs.FolderI shield, nilnul.fs._address.Dir name)
		{

			folder._EnsureX.Void(
				new nilnul.fs.address_.shield_.BaseDir(shield.address.en, name)
			);
		}




		static public void Void(nilnul.fs.FolderI shield, nilnul.fs._address.DstI name)
		{
			Void((shield),  new _address.Dir(name));
		}

		static public void Void(nilnul.fs.FolderI shield, nilnul.fs._address._dst.Denote name)
		{
			Void((shield),  new _address.Dir(name));
		}



		static public void Void(nilnul.fs.address_.ShieldI shield, nilnul.fs._address._dst.Denote name)
		{
			Void(new nilnul.fs.Folder(shield),  name);
		}


		static public void Void_ofDenote(nilnul.fs.address_.ShieldI shield, string name)
		{
			Void(shield, new _address._dst.Denote(name));
		}


		public static void Void_ofAddressDenote(string tmp, string v)
		{
			Void(
				nilnul.fs.address_.shield_._AddressX1.Create(tmp)
				,
				nilnul.fs._address.Dir.OvDenote(v)
			);
		}
		static public nilnul.fs.FolderI Folder(nilnul.fs.FolderI shield, nilnul.fs._address.Dir name)
		{

			return folder._EnsureX.Folder(
				new nilnul.fs.address_.shield_.BaseDir(shield.address.en, name)
			);
		}
		static public nilnul.fs.FolderI Folder(nilnul.fs.AddressI shield, nilnul.fs._address.DirI name)
		{
			return folder._EnsureX.Folder(
				new nilnul.fs.address_.shield_.BaseDir(shield, name)
			);
		}

		static public nilnul.fs.FolderI Folder(nilnul.fs.AddressI shield, nilnul.fs._address.Dir name)
		{
			return Folder(
				shield,(fs._address.DirI)name
			);

		}

		static public nilnul.fs.FolderI Folder(nilnul.fs.AddressI shield, nilnul.fs._address.DstI name)
		{
			return Folder(shield, new _address.Dir(name));
		}

		static public nilnul.fs.FolderI Folder(nilnul.fs.AddressI shield, nilnul.fs._address._dst.Denote name)
		{

			return Folder(
				shield, new _address.Dir( name)
			);
		}


		public static nilnul.fs.FolderI _Folder_of__Address_Denote(string folder, string dir)
		{

			return Folder(
				nilnul.fs.AddressA.Parse(folder), new _address._dst.Denote(dir)
			);
		}

		public static nilnul.fs.FolderI _Folder_of__Address_Dst(string folder, string dir)
		{

			return Folder(
				nilnul.fs.AddressA.Parse(folder),  _address.DstA.Parse(dir)
			);
		}



		static public nilnul.fs.FolderI Folder_ofDenote(nilnul.fs.address_.ShieldI shield, string name)
		{
			return Folder(shield, new _address._dst.Denote(name));
		}
		static public nilnul.fs.FolderI Folder_ofDenote(nilnul.fs.address_.Shield shield, string name)
		{
			return Folder_ofDenote((address_.ShieldI)shield, name);
		}


		public static FolderI Folder_ofDenote(Folder folder, string dir)
		{
			return Folder_ofDenote(folder.address.en, dir);
		}
		public static FolderI Folder_ofDenote(DirectoryInfo folder, string dir)
		{
			return Folder_ofDenote((nilnul.fs.address_.Shield)(folder), dir);
		}


	}
}
