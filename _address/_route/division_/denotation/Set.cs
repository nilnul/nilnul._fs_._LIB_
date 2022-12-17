using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document
{
	public class Set : nilnul.obj.Set<nilnul.fs._address.DocumentI, nilnul.fs._address.document.Eq>
	{
		public Set(params DocumentI[] vars) : base(vars)
		{
		}
	}
}
