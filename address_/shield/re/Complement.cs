namespace nilnul.fs.address_.shield.re
{
	public class Complement<T> : nilnul.obj.re.Complement<nilnul.fs.address_.ShieldI, T>
		, ReI
	where T : nilnul.fs.address_.shield.ReI, new()
	{


#pragma warning disable CS0108 // 'Complement<T>.Singleton' hides inherited member 'Complement<ShieldI, T>.Singleton'. Use the new keyword if hiding was intended.
		static public Complement<T> Singleton
#pragma warning restore CS0108 // 'Complement<T>.Singleton' hides inherited member 'Complement<ShieldI, T>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Complement<T>>' is obsolete
				return nilnul._obj.Singleton<Complement<T>>.Instance;
#pragma warning restore CS0612 // 'Singleton<Complement<T>>' is obsolete
			}
		}

	}
}
