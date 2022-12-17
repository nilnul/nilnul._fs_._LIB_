using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.driveEntry.be_
{
	public class Container : BeI
	{
		public bool be(DriveEntry obj)
		{
			return obj.entry is nilnul.fs.address_._driveEntry_.entry_.ContainerI;

			throw new NotImplementedException();
		}

		static public readonly Container Singleton = nilnul.obj.SingletonByDefault<Container>.Instance;

	}
}
