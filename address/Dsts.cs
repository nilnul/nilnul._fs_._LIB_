using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address
{
	static public class _DstsX
	{
		static public IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.AddressI address) {
			if (nilnul.fs.address.be_.Location.Singleton.be(address) )
			{
				return nilnul.fs.location._DstsX.Dsts(address);
			}
			return new nilnul.fs._address.DstI[0];
		}

		public static IEnumerable<nilnul.fs._address.DstI> Dsts(string v)
		{
			return Dsts(nilnul.fs.AddressA.Parse(v));
		}
	}
}
