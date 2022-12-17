namespace nilnul.fs.address.re_.sub_
{
	/// <summary>
	/// one is in the other
	/// 
	/// </summary>
	public class EndMatters : ReI
	{
		public bool re(AddressI a, AddressI b)
		{
			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route.re_.sub_.EndMatters.Singleton.re(
					a.route, b.route
				);
			}

			return false;
			//throw new NotImplementedException();
		}


		static public EndMatters Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EndMatters>.Instance;
			}
		}


		

	}
}
