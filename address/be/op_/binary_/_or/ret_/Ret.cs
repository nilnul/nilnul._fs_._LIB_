namespace nilnul.fs.address.be.op_.binary_._or.ret_
{
	public class Defaulted<TBe, TBe1> : Ret1
		where TBe : nilnul.obj.BeI1<nilnul.fs.AddressI1>, new()
		where TBe1 : nilnul.obj.BeI1<nilnul.fs.AddressI1>, new()

	{
		public Defaulted() : base(
			
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe1>.Instance
		)
		{
		}
	}
}
