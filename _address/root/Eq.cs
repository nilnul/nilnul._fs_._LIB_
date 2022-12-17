using System;
using System.Collections.Generic;

namespace nilnul.fs._address.root
{
	public class Eq : IEqualityComparer<Root>
	{
		public bool Equals(Root x, Root y)
		{
			return vol.Eq.Singleton.Equals(x.vol, y.vol);

			throw new NotImplementedException();
		}

		public int GetHashCode(Root obj)
		{
			return vol.Eq.Singleton.GetHashCode(obj.vol);
			throw new NotImplementedException();
		}


#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'nilnul.obj'
		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'nilnul.obj'

	}
}
