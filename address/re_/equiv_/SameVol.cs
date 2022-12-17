namespace nilnul.fs.address.re_.equiv_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	static public class _SameVolX
	{
		static public bool Re(nilnul.fs.AddressI a, nilnul.fs.AddressI b)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol)
				;
		}
		static public bool Re(nilnul.fs.IAddress a, nilnul.fs.IAddress b)
		{
			var address = a switch
			{
				nilnul.fs.AddressI address11 => address11
				,
				_ => nilnul.fs.AddressA.Parse(a.ToString())


			};

			var address1 = b switch
			{
				nilnul.fs.AddressI address11 => address11
				,
				_ => nilnul.fs.AddressA.Parse(a.ToString())


			};

			return Re(address,address1);


		}




	}
}
