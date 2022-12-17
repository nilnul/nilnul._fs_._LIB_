using System.IO;

namespace nilnul.fs.folder._dir
{
	static public class _CreateX
	{




		static public void Void(nilnul.fs.address_.ShieldI shield, nilnul.fs._address._dst.Denote name)
		{
			folder._CreateX.Void(
				new nilnul.fs.address_.shield_.BaseDir(shield, name)
			);
		}
		static public void Void_ofDirName(nilnul.fs.address_.ShieldI shield, string name)
		{
			Void(shield, new _address._dst.Denote(name));
		}


		public static void Void_ofAddressName(string tmp, string v)
		{
			Void(
				nilnul.fs.address_.shield_._AddressX1.Create(tmp)
				,
				nilnul.fs._address.Dir.OvDenote(v)
			);
		}

		public static Folder _Folder_of__Address_Denote(string folder, string dir)
		{
			return nilnul.fs.folder._CreateX._Folder_ofAddress(
				System.IO.Path.Combine(folder, dir)
			);
		}


		static public nilnul.fs.Folder Folder_ofDirName(nilnul.fs.address_.ShieldI shield, string name)
		{
			return _Folder_of__Address_Denote(shield.ToString(), name);
		}
		static public nilnul.fs.Folder Folder_ofDirName(nilnul.fs.address_.Shield shield, string name)
		{
			return Folder_ofDirName((address_.ShieldI)shield, name);
		}


		public static Folder Folder_ofDirName(Folder folder, string dir)
		{
			return Folder_ofDirName(folder.address.en, dir);
		}
		public static Folder Folder_ofDirName(DirectoryInfo folder, string dir)
		{
			return Folder_ofDirName((nilnul.fs.address_.Shield)(folder), dir);
		}


	}
}
