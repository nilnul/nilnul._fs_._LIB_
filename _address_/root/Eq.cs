using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.root
{
	public class Eq : IEqualityComparer<Root>
	{
		public bool Equals(Root x, Root y)
		{
			return _root_.vol.Eq.Singleton.Equals(x.vol, y.vol);

			throw new NotImplementedException();
		}

		public int GetHashCode(Root obj)
		{
			return _root_.vol.Eq.Singleton.GetHashCode(obj.vol);
			throw new NotImplementedException();
		}


		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
