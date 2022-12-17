using System.Collections.Generic;

namespace nilnul.fs._address.route
{
	public class Eq : IEqualityComparer<nilnul.fs._address.RouteI>
	{
		public bool Equals(RouteI x, RouteI y)
		{
			return nilnul.fs._address.division.Eq.Singleton.Equals(x.division, y.division);
			//throw new NotImplementedException();
		}

		public int GetHashCode(RouteI obj)
		{
			return nilnul.fs._address.division.Eq.Singleton.GetHashCode(obj.division);
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Eq>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
			}
		}

	}
}
