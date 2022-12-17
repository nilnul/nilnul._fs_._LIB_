namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one including the other
	/// </summary>
	public class Sup :
		re.Converse<Sub>,
		ReI
	{


		//public bool re(ShieldI a, ShieldI b)
		//{
		//	if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
		//	{
		//		return nilnul.fs._address.route_.stem.re_.Sup2.Singleton.re(
		//			a.stem, b.stem
		//		);
		//	}

		//	return false;
		//	//throw new NotImplementedException();
		//}


		static public Sup Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Sup>' is obsolete
				return nilnul._obj.Singleton<Sup>.Instance;
#pragma warning restore CS0612 // 'Singleton<Sup>' is obsolete
			}
		}


	}
}
