using System;

namespace nilnul.fs.address.re_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	 public class Joint : address.ReI
	{
		 public bool re(nilnul.fs.AddressI a, nilnul.fs.AddressI b)
		{
			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route.re_.Joint.Singleton.re(
					a.route, b.route
				);
			}

			return address.re_.sub_.EndMatters.Singleton.re(
				(a)
				,
				(b)
			);
		}

		static public Joint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint>.Instance;
			}
		}

		public bool re(string a, string b)
		{
			return re(
				nilnul.fs.AddressA.Parse(a)
				,
				nilnul.fs.AddressA.Parse(b)

			);
			//throw new NotImplementedException();
		}
	}
}