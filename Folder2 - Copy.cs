using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.IO;

namespace nilnul.fs
{
	public class Folder1
		: nilnul.fs.address_.shield_.Exist1
		, FolderI1

	{
		public Exist1 address => this;

		public Folder1(nilnul.fs.address_.ShieldI1 val) : base(val)
		{
		}

		public Folder1(nilnul.fs.address_.shield_.Exist1 exist) : base(exist)
		{

		}

		public Folder1(AddressI1 val) : this(address_.shield.op_.of_._AddressX.Create(val))
		{
		}

		public Folder1(DirectoryInfo folder) :
			this((nilnul.fs.address_.Shield1)(folder))
		{
		}

		static public implicit operator DirectoryInfo(Folder1 folder)
		{
			return new DirectoryInfo(folder.ToString());
		}
		static public explicit operator Folder1(DirectoryInfo folder)
		{
			return new Folder1(
				folder
			);
		}
		static public Folder1 FroShield(string shield)
		{
			return new Folder1(nilnul.fs.address_.Shield1.Parse(shield));
		}

		public static Folder1 FroAddress(SpearI1 spear)
		{
			return new Folder1(
				nilnul.fs.address_.shield.op_.of_._SpearX.Shield(spear)
			) ;
		}

		static public Folder1 FroAddress(string shield)
		{
			return new Folder1(nilnul.fs.address_.Shield1.FroAddress(shield));
		}

	}
}
