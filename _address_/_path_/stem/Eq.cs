using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_.stem
{
	public class Eq : IEqualityComparer<Stem>
	{
		public bool Equals(Stem x, Stem y)
		{
			return x.dirs.ed.SequenceEqual(y.dirs.ed, _path.dst.Eq.Singleton);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Stem obj)
		{
			return 0;

			//throw new NotImplementedException();
		}


		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
