namespace nilnul.fs.address_.spear.be
{
	public class Anto<T> : nilnul.obj.be.Anto<SpearI, T>
		, nilnul.fs.address_.spear.BeI
		where T : nilnul.fs.address_.spear.BeI, new()
	{

#pragma warning disable CS0108 // 'Anto<T>.Singleton' hides inherited member 'Anto<SpearI, T>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto<T> Singleton
#pragma warning restore CS0108 // 'Anto<T>.Singleton' hides inherited member 'Anto<SpearI, T>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto<T>>.Instance;
			}
		}

	}
}
