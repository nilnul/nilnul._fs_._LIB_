using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dnts.co_.sup
{
	static public class _DifX
	{
		static public IEnumerable<_address.IDnt> _Dnts_ofSupSub(IEnumerable<_address.IDnt> sup, IEnumerable<_address.IDnt> sub)
		{
			return sub.Skip(sup.Count());
		}

		static public IEnumerable<_address.IDnt> _Dnts_ofSupSub(DivisionI sup, DivisionI sub)
		{
			return _Dnts_ofSupSub(
				division._DenotesX.Seq(sup)
				,
				division._DenotesX.Seq(sub)
			);
		}

		public static IEnumerable<_address.IDnt> _Dnts_ofSupSub(IEnumerable<Denote> stub, DivisionI div1)
		{
			return _Dnts_ofSupSub(
				stub, 
				division._DenotesX.Seq(div1)
			);
		}
	}
}
