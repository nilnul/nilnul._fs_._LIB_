using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_.element.be_
{
	public class Exist
		: nilnul.fs.address_.volRoute_.element.BeI
	{
		public bool be(Element obj)
		{
			return System.IO.File.Exists(obj.ToString());
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