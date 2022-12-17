using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be_.ext
{
	[Obsolete()]
	public class Vow : spear.be.Vow
	{
		public Vow(be_.Ext be) : base(be)
		{
		}

		public Vow(string s):this(new Ext(s))
		{

		}

	}
}
