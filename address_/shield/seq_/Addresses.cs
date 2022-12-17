using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.seq_
{
	static public class _AddressesX
	{
		static public IEnumerable<nilnul.fs.address_.ShieldI> Seq(IEnumerable<string> addresses)
		{
			return addresses.Select(x => nilnul.fs.address_.shield_._AddressX1.Create(x));
		}
	}
}
