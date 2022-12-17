using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.doc_._exted.ext_.ovAftDot
{
	static public class SetX
	{
		static public bool Contains(IEnumerable<string> set, string name)
		{

			return set.Contains(name, StringComparer.OrdinalIgnoreCase);
		}
	}
}
