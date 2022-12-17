using nilnul.obj;

namespace nilnul.fs.address_.spear.vow
{
	public class Ee : nilnul.obj.vow.Ee1<nilnul.fs.address_.SpearI>

	{
		public Ee(SpearI val, VowI2<SpearI> vow) : base(val, vow)
		{
		}
		public Ee(SpearI val, nilnul.fs.address_.spear.VowI1 vow) : base(val,vow)
		{
		}
		public Ee(string s, VowI2<SpearI> vow) : this(new nilnul.fs.address_.Spear(s),vow)
		{

		}

	}
}
