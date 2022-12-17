using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.denote_._exted.ext
{
	[Obsolete()]
	public class Set : nilnul.obj.set_.EqDefaulted< _address.doc_._exted. ExtI, _address.doc_._exted. ext.Eq>
	{
		public Set(IEnumerable<string> ext) : base(
			ext.Select(x => new _address.doc_._exted.Ext(x))
		)
		{

		}

		public Set(IEnumerable<_address.doc_._exted. ExtI> exts) : base(exts)
		{

		}

		public Set(params string[] x) : this((IEnumerable<string>)x)
		{

		}
	}
}
