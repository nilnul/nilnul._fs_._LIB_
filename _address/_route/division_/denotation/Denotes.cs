using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.document
{
	[Obsolete()]
	static public class _DenotesX
	{
		static public IEnumerable<_dst.Denote> Seq(DocumentI document)
		{
			return nilnul.fs._address.div._DenotesX.Seq(document.div).Concat
				(new[] { (document.doc.denote) }
			);
		}
	}
}
