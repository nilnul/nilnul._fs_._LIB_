using System;
using System.Collections.Generic;

namespace nilnul.fs.address_.shield.set
{
	public interface EqI : IEqualityComparer<ShieldsI>
	{

	}
	public class Eq : EqI
	{
		public bool Equals(ShieldsI x, ShieldsI y)
		{
			return shields.re_.Cover.Singleton.re(x, y)
				&&
			shields.re_.Cover.Singleton.re(y, x)

				;
			//throw new NotImplementedException();
		}

		public bool eq(IEnumerable<ShieldI> x, IEnumerable<ShieldI> y)
		{
			return shields.re_.Cover.Singleton.re(x, y)
				&&
			shields.re_.Cover.Singleton.re(y, x)

				;
			//throw new NotImplementedException();
		}

		public bool eq_ofAddresses(IEnumerable<string> x, IEnumerable<string> y)
		{
			return shields.re_.Cover.Singleton.re_ofAddresses(x, y)
				&&
			shields.re_.Cover.Singleton.re_ofAddresses(y, x)

				;
			//throw new NotImplementedException();
		}



		public int GetHashCode(ShieldsI obj)
		{
			return 0;
			throw new NotImplementedException();
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
