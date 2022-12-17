using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs
{
	static public class AddressesX
	{
		static public IEnumerable<nilnul.fs.AddressI> Parse(
			IEnumerable<string> txts
		) {
			return txts.Select(
				t=> nilnul.fs.AddressA.Parse(t)
			);
		}

		static public IEnumerable<nilnul.fs.AddressI> ParsePadded(
			IEnumerable<string> txts
		) {
			return Parse( txts.Select(
				t=> (t.Trim())
			));
		}

		static public IEnumerable<nilnul.fs.AddressI> Parse_trimEachDelEmpty(
			IEnumerable<string> txts
		) {
			return Parse( new nilnul.txts_.trim_.SkipEmpty(txts) );
		}


	}
}
