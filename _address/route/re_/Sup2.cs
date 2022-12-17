namespace nilnul.fs._address.route.re_
{
	

	public class Sup : re.Converse<Sub>
	{
		

		static public Sup Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Sup2>' is obsolete
				return nilnul.obj_.Singleton<Sup>.Instance;
#pragma warning restore CS0612 // 'Singleton<Sup2>' is obsolete
			}
		}


	}
}
