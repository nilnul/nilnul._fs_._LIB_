namespace nilnul.fs.address.co_.shieldSpear.be_
{
	/// <summary>
	/// one is in the other
	/// </summary>
	public class Sup 
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

		public bool be(address_.ShieldI a, address_.SpearI b)
		{

			return nilnul.fs.address_.shield.re_.Sup.Singleton.re(
				a
				,
				nilnul.fs.address_.spear._ContainerX.Shield(b)

			);
		}

		static public Sup Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sup>.Instance;
			}
		}

	}
}
