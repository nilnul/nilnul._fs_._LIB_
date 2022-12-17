using nilnul.fs.address_.shield_.based_;
using System;

namespace nilnul.fs.folder
{
	static public class _CreateX
	{

		public static void _Void_ofAddress(string x)
		{

			/// if overlong, throws too long exception
			///

			System.IO.Directory.CreateDirectory(nilnul.fs.address._OverlongX.PrependIfNeed(x));


			//throw new NotImplementedException();
		}
		public static void Void(nilnul.fs.address_.ShieldI realDir)
		{

			_Void_ofAddress(realDir.ToString());
			//throw new NotImplementedException();
		}
		public static void Void(nilnul.fs.AddressI1 child)
		{
			_Void_ofAddress(child.ToString());

		}

		public static Folder _Folder_ofAddress(string shield)
		{
			_Void_ofAddress(shield);

			return fs.Folder.FroAddress(shield);
			//throw new NotImplementedException();
		}

		public static Folder1 Folder(nilnul.fs.AddressI1 child)
		{
			Void(child);
			return new Folder1(child);

		}

		public static Folder1 _Folder_ofAddress1(string shield)
		{
			_Void_ofAddress(shield);

			return fs.Folder1.FroAddress(shield);
			//throw new NotImplementedException();
		}

		public static Folder Folder(address_.shield_.BaseDir shield)
		{
			return _Folder_ofAddress(shield.ToString());

			//throw new NotImplementedException();
		}


	}
}
