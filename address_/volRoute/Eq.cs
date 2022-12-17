using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute
{
	[Obsolete()]

	public class Eq : IEqualityComparer<VolRouteI>
	{
		public bool Equals(VolRouteI x, VolRouteI y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol, y.vol)
				&&
				nilnul.fs._address.route.Eq.Singleton.Equals(x.route,y.route)
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(VolRouteI obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route.Eq.Singleton.GetHashCode(obj.route)
				
			;
			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Eq>.Instance;
			}
		}

	}
}
