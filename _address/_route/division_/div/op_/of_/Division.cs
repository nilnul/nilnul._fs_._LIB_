using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div_
{
	[Obsolete(nameof(_DivisionX1))]
	static public class _DivisionX
	{
		static public DivI Fro(DivisionI division ) {
			switch (division)
			{
				case DivI div:
					return div;
				case DocumentI1 document:
					return div.co_.Concat.Singleton.op(document.div, document.doc);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public DivI Fro(string division) {
			return Fro(
				nilnul.fs._address.DivisionX.Parse(division)
			);
		}
	}
}
