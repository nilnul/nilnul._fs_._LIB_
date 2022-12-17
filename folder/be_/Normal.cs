using nilnul.fs.address_;
using System;
using System.IO;

namespace nilnul.fs.folder.be_
{
	static public class _NormalX
	//: BeI
	{
		public static bool Be(DirectoryInfo directoryInfo) => !_SymlinkX.Be(directoryInfo);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fullName">shield</param>
		/// <returns></returns>
		/// 
		[Obsolete()]
		public static bool Be(string fullName)
		{
			return !_SymlinkX.Be_ofAddress(fullName);
		}

		public static bool Be(nilnul.fs.FolderI fullName)
		{
			return !_SymlinkX.Be_ofAddress(fullName.ToString());
		}



		public static bool Be_ofAddress(string fullName)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(fullName));
		}

		public static bool Be_ofShield(string fullName)
		{
			return Be(nilnul.fs.address_.Shield.Parse(fullName));
		}


		public static bool Be(ShieldI shield1)
		{
#pragma warning disable CS0612 // '_NormalX.Be(string)' is obsolete
			return Be(shield1.ToString());
#pragma warning restore CS0612 // '_NormalX.Be(string)' is obsolete
			//throw new NotImplementedException();
		}
	}

	public class Normal : BeA
	{
		public override bool be(FolderI obj)
		{
			return _NormalX.Be(obj);
			throw new NotImplementedException();
		}

		public bool be(Folder obj)
		{
			return be((nilnul.fs.FolderI)obj);
		}

		public bool be(nilnul.fs.address_.ShieldI address)
		{
			return be(
				new nilnul.fs.Folder(address)
			);

		}


		//public bool be_ofShield(string address) {

		//	return be( nilnul.fs.address_.Shield.Parse(address));
		//}

		//public bool be_ofAddress(string address) {

		//	return be_ofShield(nilnul.fs.address_.shield_._AddressX1.Txt(address));
		//}

		public bool be(DirectoryInfo info)
		{
			return be(new nilnul.fs.Folder(info));
			;
		}

		static public Normal Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Normal>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Normal>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Normal>' is obsolete: 'nilnul.obj_.'
			}
		}


	}
}
