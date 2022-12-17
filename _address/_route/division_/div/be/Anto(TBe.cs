namespace nilnul.fs._address.div.be
{
	public class Anto<TBe> : nilnul.obj.be.Anto<DivI, TBe>
		where TBe : BeI, new()
	{

#pragma warning disable CS0108 // 'Anto<TBe>.Singleton' hides inherited member 'Anto<DivI, TBe>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto<TBe> Singleton
#pragma warning restore CS0108 // 'Anto<TBe>.Singleton' hides inherited member 'Anto<DivI, TBe>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Anto<TBe>>' is obsolete
				return nilnul._obj.Singleton<Anto<TBe>>.Instance;
#pragma warning restore CS0612 // 'Singleton<Anto<TBe>>' is obsolete
			}
		}

	}
}
