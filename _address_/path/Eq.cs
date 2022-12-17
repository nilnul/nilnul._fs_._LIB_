using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path
{
	public class Eq : IEqualityComparer<Path>
	{
		public bool Equals(Path x, Path y)
		{
			return path.Normalize.ToDsts(x).SequenceEqual(path.Normalize.ToDsts(y), _path.dst.Eq.Singleton);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Path obj)
		{
			return 0;

			//throw new NotImplementedException();
		}


		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
