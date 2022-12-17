using nilnul.obj;

namespace nilnul.fs.address.be.op_.binary_._or
{
	public class Ret : nilnul.obj.be.op_.binary_._or.Ret<nilnul.fs.AddressI>
		,
		nilnul.fs.address.BeAI
	{
		public Ret(BeI1<AddressI> arg, BeI1<AddressI> arg1) : base(arg, arg1)
		{
		}
		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA.Parse(obj));
		}

	}
}
