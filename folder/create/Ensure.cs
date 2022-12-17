using nilnul.fs._address._route.division_.div_;
using System;

namespace nilnul.fs.folder.create
{
	static public class _EnsureX
	{


		public static void _Void(string realDir)
		{
			System.IO.Directory.CreateDirectory(realDir);
			//throw new NotImplementedException();
		}
		public static void Void(nilnul.fs.address_.ShieldI realDir)
		{
			_Void(realDir.ToString());
			//throw new NotImplementedException();
		}

		public static void Vod(nilnul.fs.address_.ShieldI1 realDir)
		{
			_Void(realDir.ToString());
			//throw new NotImplementedException();
		}

		public static void Vod(AddressI1 ee, DirectoryI key)
		{
			_Void(
				System.IO.Path.Combine(ee.ToString(),key.ToString())
			);

		}
		public static void Vod(FolderableI empty, _address._route.division_.div_.DirectoryI key)
		{

			Vod(
				empty.addressee.ee, key
			);

		}


		public static void Vod(FolderableI empty, _address._route.division_.DestinationI key)
		{
			Vod(empty, _address._route.division_.div_.Directory.Of(key));

		}


		public static Folder _Folder_ofAddress(string shield)
		{
			_Void(shield);

			return fs.Folder.FroAddress(shield);
			//throw new NotImplementedException();
		}
		public static Folder Folder(AddressI shield)
		{


			return _Folder_ofAddress(shield.ToString());
			//throw new NotImplementedException();
		}

		public static Folder Folder(address_.shield_.BaseDir shield)
		{


			return _Folder_ofAddress(shield.ToString());
			//throw new NotImplementedException();
		}




	}
}
