using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.set
{
	static public class _HasX
	{

		static public bool Bit(IEnumerable<address_.ShieldI> shields, address_.ShieldI shield)
		{
			return shields.Any(c => address_.shield.Eq.Singleton.Equals(c, shield));
		}

		static public bool Bit_ofShields(IEnumerable<string> shields, string shield)
		{
			return Bit(
				shields.Select(x => address_.Shield.Parse(x))
				,
				address_.Shield.Parse(shield)
			);
		}

		static public bool Bit_ofAddresses(IEnumerable<string> shields, string shield)
		{
			return Bit(
				shields.Select(x => address_.shield_._AddressX1.Create(x))
				,
				address_.shield_._AddressX1.Create(shield)
			);
		}
	}
}
