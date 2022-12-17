using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	static public class _DivisionX1
	{
		[Obsolete("defending against obsolete types")]
		static public DivI1 Fro(DivisionI division) {
			return Fro(division.ToString());
		}
		static public DivI1 _Fro(DivisionI division ) {
			switch (division)
			{
				case DivI1 div:
					return div;
				case DocumentI2 document:
					return div.co_.Concat1.Singleton.op(document.div, document.doc);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public DivI1 Fro(string division) {
			return _Fro(
				nilnul.fs._address.DivisionA.Parse(division)
			);
		}
	}
}
