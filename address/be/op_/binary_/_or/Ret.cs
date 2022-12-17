using nilnul.obj;

namespace nilnul.fs.address.be.op_.binary_._or
{
	public class Ret1 : nilnul.obj.be.op_.binary_._or.Ret<nilnul.fs.AddressI1>
		,
		nilnul.fs.address.BeAI1
	{
		public Ret1(BeI1<AddressI1> arg, BeI1<AddressI1> arg1) : base(arg, arg1)
		{
		}
		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA1.Parse(obj));
		}

	}
}
