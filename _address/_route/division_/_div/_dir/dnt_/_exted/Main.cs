namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted
{
	/// <summary>
	/// </summary>
	public class Stub : nilnul.txt.vow.En1<_stub.txt.be.Vow>
		, StubI
	{




		public Stub(string name) : base(name)
		{




		}

		public Stub(StubI main):base(main.ToString())
		{
		}

		static public Stub Ov(StubI a) {
			return a switch
			{
				Stub s=>s
				,
				_ => new Stub(a.ToString())
			};
		}
	}
}
