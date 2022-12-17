namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// proper pure
	/// </summary>
	/// 
	public class SubProp : ReI2
	{
		public bool re(StemI x, StemI y)
		{
			return Sub.Singleton.re(x,y) && stem.eq.Ne.Singleton.ne(x,y);
			//throw new NotImplementedException();
		}


		static public SubProp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SubProp>.Instance;
			}
		}


	}
}
