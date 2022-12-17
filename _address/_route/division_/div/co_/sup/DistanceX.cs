using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.duo_.sup
{
	[Obsolete()]
	static public class _DistanceX
	{
		static public int _Int_ofSupSub(DivI1 sup, DivI1 sub)
		{
			return sub.dirs.Count()-sup.dirs.Count();
		}
		static public uint _ofSupSub(DivI1 sup, DivI1 sub)
		{
			return (uint)_Int_ofSupSub(sup, sub);
		}
	}
}
