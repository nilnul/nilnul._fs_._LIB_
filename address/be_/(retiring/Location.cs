using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	[Obsolete()]
	public class Location : BeI
	{
		public bool be(Address obj)
		{
			if (Container.Singleton.be(obj))
			{
				return Folder.Singleton.be(obj);
			}
			else
			{
				return  File.Singleton.be(obj)  || Folder.Singleton.be(obj);
			}
		}

		static public readonly Location SingletonInstance = nilnul.obj.SingletonByDefault<Location>.Instance;

	}
}
