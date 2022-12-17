namespace nilnul.fs.address.re_
{
	/// <summary>
	/// one is in the other. disrespect the ending slash
	/// </summary>
	public class Sub : ReI
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

		public bool re(AddressI a, AddressI b)
		{

			return nilnul.fs.address_.shield.re_.Sub.Singleton.re(
				nilnul.fs.address_.Shield.FroAddress(a)
				,
				nilnul.fs.address_.Shield.FroAddress(b)

			);
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
