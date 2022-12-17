namespace nilnul.fs.folder
{
	public interface BeI1 :
		nilnul.obj.BeI1<nilnul.fs.FolderI1>
	{
	}

	public interface BeAI1
		:
		BeI1,
		nilnul.fs.address.BeI1

	{

		bool be_ofAddress(string txt);
		bool be_ofShield(string txt);
		bool be_ofSpear(string txt);
	}
	public abstract class BeA1 :
		nilnul.fs.address.BeA1
		,
		BeAI1
	{
		public abstract bool be(FolderI1 obj);

		public override bool be(AddressI1 obj)
		{
			return be(new Folder1(obj));
		}
		public bool be_ofAddress(string txt)
		{
			return be(Folder1.FroAddress(txt));
		}
		public bool be_ofShield(string txt)
		{
			return be(Folder1.FroShield(txt));
		}

		public bool be_ofSpear(string txt)
		{
			return be(Folder1.FroAddress(txt));
		}
	}
	static public class BeIX1
	{
		static public bool Be(this nilnul.fs.folder.BeI1 be, nilnul.fs.FolderI1 address)
		{
			return ((nilnul.obj.BeI1<nilnul.fs.FolderI1>)be).be((address));
		}

		static public bool Be(this nilnul.fs.folder.BeI1 be, nilnul.fs.AddressI1 address)
		{
			return Be(be, new nilnul.fs.Folder1(address));
		}

		static public bool Be_ofAddress(this nilnul.fs.folder.BeI1 be, string address)
		{
			return Be(be, nilnul.fs.AddressA1.Parse(address));
		}

	}


}
