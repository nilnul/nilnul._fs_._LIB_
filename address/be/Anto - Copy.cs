using System;

namespace nilnul.fs.address.be
{
	[Obsolete()]
	public class Anto1<TBe>
		:
		nilnul.obj.be.Anto<nilnul.fs.AddressI>
		,
		nilnul.fs.address.BeAI
	{
		public Anto1(nilnul.obj.BeI1<AddressI> be) : base(be)
		{
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA.Parse(obj));
		}

	}
}
