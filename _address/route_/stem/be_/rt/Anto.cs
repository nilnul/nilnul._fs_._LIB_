namespace nilnul.fs._address.route_.stem.be_.rt
{
	public class Anto : be.Anto<Rt>, BeI1
	{

#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Rt>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<Rt>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Anto>' is obsolete
				return nilnul._obj.Singleton<Anto>.Instance;
#pragma warning restore CS0612 // 'Singleton<Anto>' is obsolete
			}
		}

	}
}
