namespace nilnul.fs.address.re_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class SubProp : ReI
	{


		public bool re(AddressI a, AddressI b)
		{
			return nilnul.fs.address.re_.Sub.Singleton.re(a,b) && address.eq.Ne.Singleton.ne(a,b);
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
