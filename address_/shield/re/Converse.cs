namespace nilnul.fs.address_.shield.re
{
	public class Converse<T> : nilnul.obj.re.Converse<nilnul.fs.address_.ShieldI, T>
		, ReI
	where T : nilnul.fs.address_.shield.ReI, new()
	{


#pragma warning disable CS0108 // 'Complement<T>.Singleton' hides inherited member 'Complement<ShieldI, T>.Singleton'. Use the new keyword if hiding was intended.
		static public Converse<T> Singleton
#pragma warning restore CS0108 // 'Complement<T>.Singleton' hides inherited member 'Complement<ShieldI, T>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Complement<T>>' is obsolete
				return nilnul._obj.Singleton<Converse<T>>.Instance;
#pragma warning restore CS0612 // 'Singleton<Complement<T>>' is obsolete
			}
		}

	}
}
