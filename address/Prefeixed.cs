using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address
{
	static public class _PrefixedX
	{
		static public string Unprefix(string x) {
			return _UrlX.Unprefix( _OverlongX.Unprefix( x) );
		}
	}
}
