namespace nilnul.fs.address.be
{
	public class Anto2<TBe>
		:
		nilnul.obj.be.Anto<nilnul.fs.AddressI1>
		,
		nilnul.fs.address.BeAI1
	{
		public Anto2(nilnul.obj.BeI1<AddressI1> be) : base(be)
		{
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA1.Parse(obj));
		}

	}
}
