using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnt
{
	public class Set : nilnul.obj.set_.EqDefaulted<_dir.DntI, dnt.Eq>
	{
		public Set()
		{
		}

		public Set(params DntI[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<DntI> elements) : base(elements)
		{
		}

		public Set(IEnumerable<string> docs):this(
			docs.Select(x=> new Dnt(x))
		)
		{
		}

		public Set(params string[] docs):this(
			(IEnumerable<string>)docs
		)
		{
		}


		public bool contain(string doc) {
			return this.Contains(new Dnt(doc));
		}
	}
}
