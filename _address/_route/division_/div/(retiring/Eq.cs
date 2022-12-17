using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	public class Eq1
		: IEqualityComparer<nilnul.fs._address.DivI1>
	{
		public bool Equals(DivI1 x, DivI1 y)
		{
			return nilnul.obj.str_.enumable.Eq<DirI1, dir.Eq1>.Singleton.Equals(x.dirs,y.dirs);

			//throw new NotImplementedException();
		}

		public int GetHashCode(DivI1 obj)
		{
			return nilnul.obj.str_.enumable.Eq<DirI1, dir.Eq1>.Singleton.GetHashCode(obj.dirs);
			//throw new NotImplementedException();
		}



		static public Eq1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq1>.Instance;
			}
		}


	}
}
