using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_.div
{
	static public class _RegressionsX
	{
		static public _address.Div ToOldDiv(
			this DivI div
		) {
			return new _address.Div( (div as IEnumerable<_div.DirI>).Select(a=>_div.dir._RegressionsX.ToOld(a)) );
		}

		static public _address._route.division_.Div ToNew(
			this _address.DivI div
		) {
			return new Div( (div.dirs).Select(a=>_div.dir._RegressionsX.ToNew(a)) );
		}

	}
}
