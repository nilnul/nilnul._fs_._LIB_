using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	public class Element : BeI1
	{
		public bool be(AddressI1 obj)
		{
			return nilnul.fs._address.route.be_.Open.Singleton.be(obj.route);
			throw new NotImplementedException();
		}


		static public Element Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Element>.Instance;
			}
		}

	}
}
