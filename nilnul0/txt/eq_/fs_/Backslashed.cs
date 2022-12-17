using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.eq_.fs_
{
	public class Backslashed : nilnul.txt.eq_.homo_.EqDefaultOvCaseInsensitive
	{
		public Backslashed() : base(
			 nilnul.txt.op_.unary_.fs_.Backslashed.Singleton.op
		)
		{
		}


		static public Backslashed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Backslashed>.Instance;
			}
		}

	}
}
