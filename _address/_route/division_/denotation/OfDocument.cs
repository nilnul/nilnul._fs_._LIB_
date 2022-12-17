using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.denotation
{
	static public class _OfDocumentX
	{
		static public _address.Denotation Denotation(DocumentI document) {
			return new _address.Denotation(
				document.div
				,
				nilnul.fs._address.dnt._OfDocX.OfDoc(
					document.doc
				)
			);
		}
	}
}
