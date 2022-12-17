using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.eq_
{
	[Obsolete()]
	public class ContainerElementDif : IEqualityComparer<nilnul.fs.Address>
	{
		public bool Equals(Address x, Address y)
		{
			return nilnul.fs._address_.root.Eq.Singleton.Equals(x.root, y.root)
				&&
				nilnul.fs._address_.path.eq_.CollectionElementNeq.Singleton.Equals(x.path, y.path)
			;

		}

		public int GetHashCode(Address obj)
		{
			return nilnul.fs._address_.root.Eq.Singleton.GetHashCode(obj.root)
				& nilnul.fs._address_.path.eq_.CollectionElementNeq.Singleton.GetHashCode(obj.path);


		}

		static public readonly ContainerElementDif Singleton = nilnul.obj.SingletonByDefault<ContainerElementDif>.Instance;

	}
}
