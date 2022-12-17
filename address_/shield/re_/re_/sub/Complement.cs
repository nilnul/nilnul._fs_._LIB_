using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container.re_.sub
{
	public class Complement: nilnul.obj.re.Complement<nilnul.fs.address_.ContainerI1, Sub>
		,ReI
	{


		static public Complement Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Complement>.Instance;
			}
		}

	}
}
