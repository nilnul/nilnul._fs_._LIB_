using System;

namespace nilnul.fs._address.route_.stem.re_
{
	static public class _DisjointX2
	{
		static public bool Re(route_.StemI x, route_.StemI y)
		{
			return !Sup2.Singleton.re(x, y) && !Sup2.Singleton.re(y, x);
			//var sharedNearestParent = stem.op_.binary_._SharedStubX.Co(x, y);

			//return stem.re_._SupX.Re(sharedNearestParent, x)
			//	&&
			//	stem.re_._SupX.Re(sharedNearestParent, y)
			//;

		}

		[Obsolete()]
		static public bool Be(route_.StemI x, route_.StemI y)
		{
			return Re(x, y);
			

		}


	}
}
