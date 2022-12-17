using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	public class Eq
		: IEqualityComparer<nilnul.fs._address.DivI>
	{
		public bool Equals(DivI x, DivI y)
		{
			return nilnul.fs._address.dirs.Eq.Singleton.Equals(x.dirs,y.dirs);
			//throw new NotImplementedException();
		}

		public int GetHashCode(DivI obj)
		{
			return nilnul.fs._address.dirs.Eq.Singleton.GetHashCode(obj.dirs);
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
