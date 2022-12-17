using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_.container.be_
{
	public class Exist
		: nilnul.fs.address_.volRoute_.container.BeI
	{
		public bool be(Container obj)
		{
			return System.IO.Directory.Exists(obj.ToString());
			//throw new NotImplementedException();
		}

		static public Exist Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Exist>.Instance;
			}
		}
	}
}