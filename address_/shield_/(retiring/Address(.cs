using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	static public class _AddressX 
	{
		

		static public Shield Create(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return Create(s.processed);
		}


		static public Shield Create(AddressI1 address) {
			return new Shield(
				address.vol
				,
				fs._address.route_.stem_._RouteX1.Fro(
					address.route
				)
			);
		}

		static public Shield Create(string  address) {
			return Create( nilnul.fs.AddressA1.Parse(address));
		}



	}
}
