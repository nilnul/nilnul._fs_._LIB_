using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address
{
	static public class _RegressionsX
	{
		static public nilnul.fs.AddressI ToVerNil(
			this nilnul.fs.AddressI1 address
		) {
			return nilnul.fs.AddressA.Parse(address.ToString());
		}
	}
}
