using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.duo_.sup
{
	[Obsolete()]
	static public class _DifX1
	{
		static public IEnumerable<DirI1> _Dirs_ofSupSub(DivI1 sup, DivI1 sub)
		{
			return sub.dirs.Skip(sup.dirs.Count());
		}
		static public Div1 _ofSupSub(DivI1 sup, DivI1 sub)
		{
			return new Div1(_Dirs_ofSupSub(sup, sub));
		}
	}
}
