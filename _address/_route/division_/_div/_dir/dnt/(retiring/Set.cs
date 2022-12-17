using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._dst.denote
{
	[Obsolete()]
	public class Set : nilnul.obj.set_.EqDefaulted<_dst.Denote, denote.Eq>
	{
		public Set()
		{
		}

		public Set(params Denote[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Denote> elements) : base(elements)
		{
		}

		public Set(IEnumerable<string> docs):this(
			docs.Select(x=> new Denote(x))
		)
		{
		}

		public Set(params string[] docs):this(
			(IEnumerable<string>)docs
		)
		{
		}


		public bool contain(string doc) {
			return this.Contains(new Denote(doc));
		}
	}
}
