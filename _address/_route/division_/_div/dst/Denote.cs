using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dst
{
	static public class _DenoteX
	{
		static public string Denote(string dst) {

			return nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(dst) ? dir._denote._TxtX.Denote(dst) : dst;
		}
	}
}
