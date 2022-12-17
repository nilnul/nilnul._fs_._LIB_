using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext
{
	public class Set : nilnul.obj.set_.EqDefaulted< _address._route.division_._div._dir.dnt_._exted. ExtI
		,
		_address._route.division_._div._dir.dnt_._exted. ext.Eq
	>
	{
		public Set(IEnumerable<string> ext) : base(
			ext.Select(x => new _address._route.division_._div._dir.dnt_._exted.Ext(x))
		)
		{

		}

		public Set(IEnumerable<_address._route.division_._div._dir.dnt_._exted. ExtI> exts) : base(exts)
		{

		}

		public Set(params string[] x) : this((IEnumerable<string>)x)
		{

		}
	}
}
