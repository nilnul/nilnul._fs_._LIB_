using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.folder.directory.create
{
	static public class _EnsureX
	{

		static public void Void(
			nilnul.fs.FolderI shield,
			nilnul.fs._address.DirectoryI name)
		{
			folder._EnsureX.Void(
				new nilnul.fs.address_.shield_.BaseDiv(shield.address.en, name)
			);
		}
		static public void Void(
			nilnul.fs.FolderI shield
			,
			string name
		)
		{
			Void(
				(shield),

				_address.Directory.Parse(name)
			);
		}

		static public void Void(
			nilnul.fs.address_.ShieldI shield
			,
			nilnul.fs._address.DirectoryI name
		)
		{
			Void(
				new nilnul.fs.Folder(shield), name
			);
		}


		static public void Void(nilnul.fs.address_.ShieldI shield, string name)
		{
			Void(shield, _address.Directory.Parse(name));
		}


		public static void Void_ofAddress(string tmp, string v)
		{
			Void(
				nilnul.fs.Folder.FroAddress(tmp)
				,
				v
			);
		}


		static public nilnul.fs.Folder Folder(nilnul.fs.FolderI shield, DirectoryI name)
		{
			return folder._EnsureX.Folder(new nilnul.fs.address_.shield_.BaseDiv(shield.address.en, name));
		}
		static public nilnul.fs.Folder Folder(nilnul.fs.FolderI shield, nilnul.fs._address.DestinationI name)
		{
			return Folder(shield,
				 nilnul.fs._address.DirectoryIX.Ov(
					 name
				)
			);
		}

		public static Folder Folder(Folder folder, string dir)
		{
			return Folder(
				folder
				,
				nilnul.fs._address.Directory.Parse(dir)
			);
		}
		public static nilnul.fs.Folder Folder_ofShieldDirectory(string tmp, string v)
		{
			return Folder(
				nilnul.fs.Folder.FroShield(tmp)
				,
				v
			);
		}
		public static Folder Folder_directoryInDestination(FolderI folder, string dir)
		{
			return Folder(
				folder
				,
				nilnul.fs._address.DestinationA.Parse(dir)
			);
		}
		public static nilnul.fs.Folder Folder_ofShieldDestination(string tmp, string v)
		{
			return Folder_directoryInDestination(
				nilnul.fs.Folder.FroShield(tmp)
				,
				v
			);
		}
		public static nilnul.fs.Folder Folder_ofAddressDirectory(string tmp, string v)
		{
			return Folder(
				nilnul.fs.Folder.FroAddress(tmp)
				,
				v
			);
		}
		public static nilnul.fs.Folder Folder_ofAddressDestination(string tmp, string v)
		{
			return Folder_directoryInDestination(
				nilnul.fs.Folder.FroAddress(tmp)
				,
				v
			);
		}




		static public nilnul.fs.Folder Folder(nilnul.fs.address_.ShieldI shield, string name)
		{
			return Folder(
				new nilnul.fs.Folder(shield)
				, name
				);
		}

		static public nilnul.fs.Folder Folder(nilnul.fs.address_.Shield shield, string name)
		{
			return Folder((address_.ShieldI)shield, name);
		}


		public static Folder Folder(DirectoryInfo folder, string dir)
		{
			return Folder((nilnul.fs.address_.Shield)(folder), dir);
		}


	}
}
