using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.shield_
{
	public class Vol1 :
		nilnul.obj.Box<nilnul.fs._address.VolI>
		,

		ShieldI
	{
		public Vol1(VolI val) : base(val)
		{
		}

		public StemI stem => new nilnul.fs._address.route_.Stem();

		public VolI vol => boxed;

		public RouteI route => stem;

		public override string ToString()
		{
			return $"{ base.ToString()}{_address._route._SeparatorX.Default}";
		}
	}
}
