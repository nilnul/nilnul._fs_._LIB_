using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path.dst_.doc_._dotted.ext.set
{
	static public class X
	{
		static public bool Contains(IEnumerable<string> set, string name) {

			return set.Contains(name, StringComparer.OrdinalIgnoreCase);
		}
	}
}
