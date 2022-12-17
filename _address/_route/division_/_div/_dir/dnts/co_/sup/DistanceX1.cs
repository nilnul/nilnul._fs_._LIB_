using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dnts.co_.sup
{
	static public class _DistanceX
	{
		static public int _Int_ofSupSub(IEnumerable<_address.IDnt> sup, IEnumerable<_address.IDnt> sub)
		{
			return sub.Count() - sup.Count();
		}
		static public uint _ofSupSub(IEnumerable<_address.IDnt> sup, IEnumerable<_address.IDnt> sub)
		{
			return (uint)_Int_ofSupSub(sup, sub);
		}

		public static int _Int_ofSupSub(IEnumerable<Denote> stub, DivisionI div)
		{
			return _Int_ofSupSub(stub, division._DenotesX.Seq(div) );
		}
	}
}
