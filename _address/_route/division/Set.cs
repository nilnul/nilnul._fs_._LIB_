using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division
{
	public class Set : nilnul.obj.Set<nilnul.fs._address.DivisionI, division.Eq>
	{
		public Set(IEnumerable<DivisionI> elements) : base(elements)
		{
		}
	}
}
