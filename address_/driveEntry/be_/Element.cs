using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.driveEntry.be_
{
	public class Element : BeI
	{
		public bool be(DriveEntry obj)
		{
			return obj.entry is nilnul.fs.address_._driveEntry_.entry_.ElementI;

			throw new NotImplementedException();
		}

		static public readonly Element Singleton = nilnul.obj.SingletonByDefault<Element>.Instance;

	}
}
