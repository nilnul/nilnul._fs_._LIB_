using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem.re_
{
	[Obsolete()]
	static public class _DisjointX
	{
		static public bool Be(route_.StemI x, route_.StemI y) {
			var sharedNearestParent = stem.co_._SharedStubX.Co(x, y);
			return stem.re_._SupX.Re(sharedNearestParent, x) 
				&& 
				stem.re_._SupX.Re(sharedNearestParent,y)
			;

		}
		static public bool Be(route_.Stem x, route_.Stem y) {
			var sharedNearestParent = stem.co_._SharedStubX.Co(x, y);
			return stem.re_._SupX.Re(sharedNearestParent, x) 
				&& 
				stem.re_._SupX.Re(sharedNearestParent,y)
			;

		}

	}
}
