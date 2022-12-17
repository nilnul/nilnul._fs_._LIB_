using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div.duo_.sup
{
	static public class _DifX2
	{
		static public IEnumerable<DirI> _Dirs_ofSupSub(DivI sup, DivI sub)
		{
			return sub.dirs.Skip(sup.dirs.Count());
		}
		static public Div _ofSupSub(DivI sup, DivI sub)
		{
			return new Div(_Dirs_ofSupSub(sup, sub));
		}
	}
}
