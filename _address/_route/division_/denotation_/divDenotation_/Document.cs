using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	static public class _DocumentX
	{
		static public Document Splice(DivI div, DocumentI division)
		{
			return new Document(
				_address.div.op_.binary_.Concat.Singleton.op(div,division.div)
				,
				division.doc
			);
		}
	}
}
