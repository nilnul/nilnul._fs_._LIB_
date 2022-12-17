using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	[Obsolete()]
	public class Container : BeI
	{
		public bool be(Address obj)
		{
			return nilnul.fs._address_.path.be_.Container.Eval(obj.path);

			throw new NotImplementedException();
		}



		static public readonly Container Singleton = nilnul.obj.SingletonByDefault<Container>.Instance;

	}
}
