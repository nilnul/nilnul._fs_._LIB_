namespace nilnul.fs.address.be.op_.binary_._and.ret_
{
	public class Defaultable<TBe, TBe1> : Ret
		where TBe : nilnul.obj.BeI1<nilnul.fs.AddressI>, new()
		where TBe1 : nilnul.obj.BeI1<nilnul.fs.AddressI>, new()

	{
		public Defaultable() : base(
			nilnul.obj_.Singleton<TBe>.Instance
			,
			nilnul.obj_.Singleton<TBe1>.Instance
		)
		{
		}
	}
}
