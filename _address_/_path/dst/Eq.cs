using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path.dst
{
	public class Eq : IEqualityComparer<DstI>, IEqualityComparer<Dst>
	{
		public bool Equals(DstI x, DstI y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(), y.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(DstI obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());
			//throw new NotImplementedException();
		}

		public bool Equals(Dst x, Dst y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(), y.ToString());

			throw new NotImplementedException();
		}

		public int GetHashCode(Dst obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());

			throw new NotImplementedException();
		}

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
