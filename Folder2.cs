using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.IO;

namespace nilnul.fs
{
	[Obsolete()]
	public class Folder
		: nilnul.fs.address_.shield_.Exist
		, FolderI

	{
		public Exist address => this;

		public Folder(nilnul.fs.address_.ShieldI val) : base(val)
		{
		}

		public Folder(nilnul.fs.address_.shield_.Exist exist) : base(exist)
		{

		}

		public Folder(AddressI val) : this(address_.shield_._AddressX1.Create(val))
		{
		}

		public Folder(DirectoryInfo folder) :
			this((nilnul.fs.address_.Shield)(folder))
		{
		}

		static public implicit operator DirectoryInfo(Folder folder)
		{
			return new DirectoryInfo(folder.ToString());
		}
		static public explicit operator Folder(DirectoryInfo folder)
		{
			return new Folder(
				folder
			);
		}
		static public Folder FroShield(string shield)
		{
			return new Folder(nilnul.fs.address_.Shield.Parse(shield));
		}

		public static Folder FroAddress(SpearI spear)
		{
			return new Folder(
				nilnul.fs.address_.shield_._SpearX.Shield(spear)
			) ;
		}

		static public Folder FroAddress(string shield)
		{
			return new Folder(nilnul.fs.address_.Shield.FroAddress(shield));
		}

	}
}
