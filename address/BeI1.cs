namespace nilnul.fs.address
{
	/*extern alias obj;*/
	public interface BeI1 :
		/*obj::*/nilnul.obj.BeI1<nilnul.fs.AddressI1>
	{
	}

	public interface BeAI1 : BeI1
		,
		nilnul.txt.BeI
	{

	}
	public abstract class BeA1 : BeI1
		,
		nilnul.txt.BeI
	{
		public abstract bool be(AddressI1 obj);

		public virtual bool be(string obj)
		{
			return be(AddressA1.Parse(obj));
			//throw new NotImplementedException();
		}
	}

	static public class BeX1
	{
		static public bool Be(this nilnul.obj.BeI1<AddressI1> be11, string s)
		{
			return be11.be(
				nilnul.fs.AddressA1.Parse(s)
			);
		}
		static public bool Be(this nilnul.fs.address.BeI1 be11, string s)
		{
			return be11.be(
				nilnul.fs.AddressA1.Parse(s)
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
