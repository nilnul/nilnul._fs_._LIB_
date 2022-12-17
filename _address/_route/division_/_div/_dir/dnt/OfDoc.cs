using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dnt
{
	static public class _OfDocX
	{
		static public _address.Dnt OfDoc(_address.DocI doc) {
			return new _address.Dnt(doc.ToString());
		}
	}
}
