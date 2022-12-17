namespace nilnul.fs.address_.shield.re_.sup
{
	public class Complement : nilnul.obj.re.Complement<nilnul.fs.address_.ShieldI, Sup>
		, ReI
	{


#pragma warning disable CS0108 // 'Complement.Singleton' hides inherited member 'Complement<ShieldI, Sup>.Singleton'. Use the new keyword if hiding was intended.
		static public Complement Singleton
#pragma warning restore CS0108 // 'Complement.Singleton' hides inherited member 'Complement<ShieldI, Sup>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Complement>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Complement>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Complement>' is obsolete: 'Singleton'
			}
		}

	}
}
