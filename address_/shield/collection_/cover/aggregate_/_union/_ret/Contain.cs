using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.collection_.cover.aggregate_._union._ret
{
	static public class _ContainX
	{
		static public bool Cover(IEnumerable<address_.ShieldI> shields, address_.ShieldI shield)
		{
			return shields.Any(c => address_.shield.re_.Sup.Singleton.re(c, shield));
		}

		static public bool Cover(IEnumerable<string> shields, string shield)
		{
			return Cover(
				shields.Select(x => address_.Shield.Parse(x))
				,
				address_.Shield.Parse(shield)
			);
		}

		static public bool Cover_inAddresses(IEnumerable<string> shields, string shield)
		{
			return Cover(
				shields.Select(x => address_.shield_._AddressX1.Create(x))
				,
				address_.shield_._AddressX1.Create(shield)
			);
		}

	}
}
