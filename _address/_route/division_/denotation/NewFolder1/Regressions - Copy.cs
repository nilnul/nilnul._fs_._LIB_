using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_.div.dnted
{

	[Obsolete]
	static public class _RegressionsX
	{
		[Obsolete]
		static public Document ToDocument(this Dnted denotation) {

			return new Document(
				div._RegressionsX.ToOldDiv(
					denotation.div
				)
				,
				_div._dir.dnt._RegressionsX.ToOldDnt(
					denotation.dnt
				)
			);
		}

		static public _route.division_.div.Dnted ToNew(this Document denotation) {

			return new Dnted(
				div._RegressionsX.ToNew(
					denotation.div
				)
				,
				_div._dir.dnt._RegressionsX.ToNew(
					denotation.dnt
				)
			);
		}

	}
}
