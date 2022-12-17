using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_
{


	public abstract class SpearA1 : SpearI1
	{
		public abstract SprigI1 sprig { get; }
		public abstract VolI vol { get; }
		public RouteI1 route { get { return sprig; } }

		static public SpearI1 OfSpear(nilnul.fs.AddressI1 address)
		{
			switch (address)
			{
				case SpearI1 spear:
					return spear;
				default:
					return Spear1.Parse(address.ToString());
					break;
			}
		}
	}
}
