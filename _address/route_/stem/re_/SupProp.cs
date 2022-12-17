namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// proper pure
	/// </summary>
	/// 
	public class SupProp : ReI2
	{
		public bool re(StemI x, StemI y)
		{
			return Sup2.Singleton.re(x,y) && stem.eq.Ne.Singleton.ne(x,y);
			//throw new NotImplementedException();
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
