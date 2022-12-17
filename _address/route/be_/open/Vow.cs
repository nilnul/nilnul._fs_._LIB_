namespace nilnul.fs._address.route.be_.open
{
	public class Vow : be.VowA<Open>
	{

#pragma warning disable CS0108 // 'Vow.Singleton' hides inherited member 'Vow1<RouteI, Open>.Singleton'. Use the new keyword if hiding was intended.
		static public Vow Singleton
#pragma warning restore CS0108 // 'Vow.Singleton' hides inherited member 'Vow1<RouteI, Open>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Vow>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Vow>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Vow>' is obsolete: 'Singleton'
			}
		}

	}
}
