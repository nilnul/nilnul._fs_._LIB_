using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public abstract class ShieldA : ShieldI
	{


		public abstract StemI stem { get; }
		public abstract VolI vol { get; }
		public RouteI route { get { return stem; } }

		static public ShieldI Ov_assumeShield(AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.ShieldI shield:
					return shield;
				default:
					return new Shield(
						address.vol
						,
						fs._address.route_.StemA.Ov_assumeStem(
							address.route
						)
					);


					break;
			}
		}
	}
}
