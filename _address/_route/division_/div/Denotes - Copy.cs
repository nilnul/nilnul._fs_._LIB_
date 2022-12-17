using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	static public class _DenotesX
	{
		static public IEnumerable<_dst.Denote> Seq(DivI div)
		{
			return div.dirs.Select(x => (x.denote));
		}
	}
}
