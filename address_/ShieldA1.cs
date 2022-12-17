using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_
{
	public abstract class ShieldA1 : ShieldI1
	{


		public abstract StemI1 stem { get; }
		public abstract VolI vol { get; }
		public RouteI1 route { get { return stem; } }

		static public ShieldI1 _Of_assumeShield(AddressI1 address)
		{
			switch (address)
			{
				case nilnul.fs.address_.ShieldI1 shield:
					return shield;
				default:
					return new Shield1(
						address.vol
						,
						fs._address.route_.StemA1._Of_assumeStem(
							address.route
						)
					);


					break;
			}
		}
	}
}
