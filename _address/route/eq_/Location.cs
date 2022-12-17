using System.Collections.Generic;

namespace nilnul.fs._address.route.eq_
{

	public class Location : IEqualityComparer<nilnul.fs._address.RouteI>
	{
		public bool Equals(RouteI x, RouteI y)
		{
			return nilnul.fs._address.division.eq_.Location.Singleton.Equals(x.division, y.division);
			//throw new NotImplementedException();
		}

		public int GetHashCode(RouteI obj)
		{
			return nilnul.fs._address.division.eq_.Location.Singleton.GetHashCode(obj.division);
			//throw new NotImplementedException();
		}

		static public Location Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Location>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
			}
		}

	}
}
