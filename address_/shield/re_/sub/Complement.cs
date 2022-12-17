using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.re_.sub
{
	[Obsolete()]
	public class Complement: nilnul.obj.re.Complement<nilnul.fs.address_.ShieldI, Sub>
		,ReI
	{


		static public Complement Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Complement>.Instance;
			}
		}

	}
}
