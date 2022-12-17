using System;

namespace nilnul.fs.folder
{
	[Obsolete()]
	public interface BeI :
		nilnul.obj.BeI1<nilnul.fs.FolderI>
	{
	}

	[Obsolete()]
	public interface BeAI
		:
		BeI,
		nilnul.fs.address.BeI

	{

		bool be_ofAddress(string txt);
		bool be_ofShield(string txt);
		bool be_ofSpear(string txt);
	}
	[Obsolete()]
	public abstract class BeA :
		nilnul.fs.address.BeA
		,
		BeAI
	{
		public abstract bool be(FolderI obj);

		public override bool be(AddressI obj)
		{
			return be(new Folder(obj));
		}
		public bool be_ofAddress(string txt)
		{
			return be(Folder.FroAddress(txt));
		}
		public bool be_ofShield(string txt)
		{
			return be(Folder.FroShield(txt));
		}

		public bool be_ofSpear(string txt)
		{
			return be(Folder.FroAddress(txt));
		}
	}

	[Obsolete()]
	static public class BeIX
	{
		static public bool Be(this nilnul.fs.folder.BeI be, nilnul.fs.FolderI address)
		{
			return ((nilnul.obj.BeI1<nilnul.fs.FolderI>)be).be((address));
		}

		static public bool Be(this nilnul.fs.folder.BeI be, nilnul.fs.AddressI address)
		{
			return Be(be, new nilnul.fs.Folder(address));
		}

		static public bool Be_ofAddress(this nilnul.fs.folder.BeI be, string address)
		{
			return Be(be, nilnul.fs.AddressA.Parse(address));
		}

	}


}
