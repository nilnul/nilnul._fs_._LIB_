using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.doc_._exted.ext
{
	[Obsolete()]
	public class Set : nilnul.obj.Set<ExtI, ext.Eq>
	{
		public Set(IEnumerable<string> ext) : base(
			ext.Select(x => new Ext(x)).ToArray()
		)
		{

		}

		public Set(IEnumerable<ExtI> exts) : base(exts)
		{

		}

		public Set(params string[] x) : this((IEnumerable<string>)x)
		{

		}
	}
}
