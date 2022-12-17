using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.duo_.sup
{
	[Obsolete()]
	static public class _DifX
	{
		static public Div _Dif_ofSupSub(DivI sup, DivI sub) {
			return new Div( sub.dirs.Skip(sup.dirs.Count()) );
		}

	}
}
