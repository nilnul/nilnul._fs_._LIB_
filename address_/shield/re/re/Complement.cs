using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container.re
{
	[Obsolete()]
	public class Complement<T>: nilnul.obj.re.Complement<nilnul.fs.address_.ContainerI1, T>
		,ReI
		where T: container.ReI,new()
	{


		static public Complement<T> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Complement<T>>.Instance;
			}
		}

	}
}
