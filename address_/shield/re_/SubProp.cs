namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class SubProp : ReI
	{
		public bool re(ShieldI a, ShieldI b)
		{
			return Sub.Singleton.re(a, b) && shield.eq.Ne.Singleton.ne(a, b);
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
