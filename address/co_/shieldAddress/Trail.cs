using nilnul.fs.address_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address.co_.shieldAddress
{
	static public class _TrailX
	{
		static public nilnul.fs.address.co._traject.IShortcut Anchor_assumePar1IsShield0Spear(ShieldI from, nilnul.fs.AddressI _shield0spear)
		{
			switch (_shield0spear)
			{
				case nilnul.fs.address_.ShieldI shield:
					return nilnul.fs.address_.shield.co._RelPathX.Anchor(from, shield);
				case nilnul.fs.address_.SpearI spear:
					return shieldSpear._RelPathX.Anchor(from, spear);

				default:

					throw new UnexpectedTypeException();
					break;
			}
			
		}

		static public nilnul.fs.address.co._traject.IShortcut Anchor(ShieldI from, nilnul.fs.AddressI to)
		{
			switch (to)
			{
				case nilnul.fs.address_.ShieldI shield:
					return nilnul.fs.address_.shield.co._RelPathX.Anchor(from, shield);
				case nilnul.fs.address_.SpearI spear:
					return shieldSpear._RelPathX.Anchor(from, spear);

				default:

					return Anchor_assumePar1IsShield0Spear(from, nilnul.fs.AddressA.Parse(to.ToString()));
					break;
			}
			
		}

	}
}
