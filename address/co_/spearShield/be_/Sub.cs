namespace nilnul.fs.address.co_.spearShield.be_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class Sub 
	{
		//public bool re(AddressI a, AddressI b)
		//{
		//	if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
		//	{
		//		return nilnul.fs._address.route.re_.Sub.Singleton.re(
		//			a.route, b.route
		//		);
		//	}

		//	return false;
		//	//throw new NotImplementedException();
		//}

		public bool be( address_.SpearI b, address_.ShieldI a)
		{

			return shieldSpear.be_.Sup.Singleton.be(a,b);
		}

		static public Sub Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sub>.Instance;
			}
		}

	}
}
