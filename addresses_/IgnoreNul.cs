using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.addresses_
{
	static public class _IgnoreNulX
	{
		static public IEnumerable<nilnul.fs.AddressI> Seq(IEnumerable<string> txt)
		{
			return txt.Select(x => nilnul.fs.address.nulable._ParseX.Parse(x)).Where(x => x != null);
		}
	}
}
