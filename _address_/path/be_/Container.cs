using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path.be_
{
	public class Container:BeI
	{
		static public bool Eval(nilnul.fs._address_.Path path) {

			return nilnul.fs._address_._path_.tip.be_.Empty.Singleton.be(path.tip);
		}

		public bool be(Path obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}
	}
}
