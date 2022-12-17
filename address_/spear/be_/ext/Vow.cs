using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be_.ext
{
	public class Vow1 : spear.be.Vow1
	{
		public Vow1(be_.Ext1 be) : base(be)
		{
		}

		public Vow1(string s):this(new Ext1(s))
		{

		}

	}
}
