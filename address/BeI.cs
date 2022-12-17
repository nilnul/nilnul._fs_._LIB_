using System;

namespace nilnul.fs.address
{
	/*extern alias obj;*/

	[Obsolete()]
	public interface BeI :
		/*obj::*/nilnul.obj.BeI1<nilnul.fs.AddressI>
	{
	}

	[Obsolete()]
	public interface BeAI : BeI
		,
		nilnul.txt.BeI
	{

	}
	[Obsolete()]
	public abstract class BeA : BeI
		,
		nilnul.txt.BeI
	{
		public abstract bool be(AddressI obj);

		public virtual bool be(string obj)
		{
			return be(AddressA.Parse(obj));
			//throw new NotImplementedException();
		}
	}

	[Obsolete()]
	static public class BeX
	{
		static public bool Be(this nilnul.obj.BeI1<AddressI> be11, string s)
		{
			return be11.be(
				nilnul.fs.AddressA.Parse(s)
			);
		}
		static public bool Be(this nilnul.fs.address.BeI be11, string s)
		{
			return be11.be(
				nilnul.fs.AddressA.Parse(s)
			);
		}

		//static public bool Be(this nilnul.fs.address.BeI be11, System.IO.FileSystemInfo s)
		//{
		//	return be11.be(
		//		nilnul.fs.AddressA.Parse(s)
		//	);
		//}

	}
}
