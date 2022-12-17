using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;

namespace nilnul.fs.address_
{

	[Obsolete()]
	public abstract class SpearA : SpearI
	{
		public abstract SprigI sprig { get; }
		public abstract VolI vol { get; }
		public RouteI route { get { return sprig; } }

		static public SpearI OfSpear(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case SpearI spear:
					return spear;
				default:
					return Spear.Parse(address.ToString());
					break;
			}
		}
	}
}
