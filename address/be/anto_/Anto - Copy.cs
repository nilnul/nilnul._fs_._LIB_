using System;

namespace nilnul.fs.address.be
{
	[Obsolete(nameof(anto_.BeDefault<TBe>))]
	public class Anto<TBe>
		:
		nilnul.obj.be.Anto<nilnul.fs.AddressI, TBe>
		,
		nilnul.fs.address.BeAI
		where TBe : nilnul.fs.address.BeI, new()
	{


#pragma warning disable CS0108 // 'Anto<TBe>.Singleton' hides inherited member 'Anto<AddressI, TBe>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto<TBe> Singleton
#pragma warning restore CS0108 // 'Anto<TBe>.Singleton' hides inherited member 'Anto<AddressI, TBe>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto<TBe>>.Instance;
			}
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA.Parse(obj));
		}

	}
}
