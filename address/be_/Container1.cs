using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	public class Container1 : BeI1
	{
		public bool be(AddressI1 obj)
		{
			return nilnul.fs._address.route.be_.Closed.Singleton.be(obj.route);

			throw new NotImplementedException();
		}


		static public Container1 Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Container1>.Instance;
			}
		}
	}
}
