namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class SupProp : ReI
	{
		public bool re(ShieldI a, ShieldI b)
		{
			return Sup.Singleton.re(a, b) && shield.eq.Ne.Singleton.ne(a, b);
		}


		static public SupProp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SupProp>.Instance;
			}
		}

	}
}
