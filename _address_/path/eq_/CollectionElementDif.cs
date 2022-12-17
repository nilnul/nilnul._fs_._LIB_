using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path.eq_
{
	[Obsolete()]
	public class CollectionElementNeq : IEqualityComparer<Path>
	{
		public bool Equals(Path x, Path y)
		{
			return 
				nilnul.fs._address_._path_.stem.Eq.Singleton.Equals(x.stem,y.stem)
				&&

				nilnul.fs._address_._path_.tip.Eq.Singleton.Equals(x.tip,y.tip)
				
				;

			//throw new NotImplementedException();
		}

		public int GetHashCode(Path obj)
		{
			return 
				nilnul.fs._address_._path_.stem.Eq.Singleton.GetHashCode(obj.stem)
				^
				nilnul.fs._address_._path_.tip.Eq.Singleton.GetHashCode(obj.tip)
				;

			//throw new NotImplementedException();
		}


		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
