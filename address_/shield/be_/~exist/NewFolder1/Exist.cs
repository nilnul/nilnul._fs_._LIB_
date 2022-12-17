using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container.be_
{
	[Obsolete()]
	public class Exist1
		: nilnul.fs.address_.container.BeI1
	{
		public bool be(ContainerI1 obj)
		{
			return System.IO.Directory.Exists(obj.ToString());

			throw new NotImplementedException();
		}




		static public Exist1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Exist1>.Instance;
			}
		}



	}
}
