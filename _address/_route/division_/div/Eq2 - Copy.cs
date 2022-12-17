using System;
using System.Collections.Generic;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	public class Eq
		: IEqualityComparer<nilnul.fs._address.DivI>
	{
		public bool Equals(DivI x, DivI y)
		{
#pragma warning disable CS0612 // 'Eq<DirI, Eq>' is obsolete
			return nilnul.obj.str_.enumable.Eq<DirI, dir.Eq>.Singleton.Equals(x.dirs, y.dirs);
#pragma warning restore CS0612 // 'Eq<DirI, Eq>' is obsolete

			//throw new NotImplementedException();
		}

		public int GetHashCode(DivI obj)
		{
#pragma warning disable CS0612 // 'Eq<DirI, Eq>' is obsolete
			return nilnul.obj.str_.enumable.Eq<DirI, dir.Eq>.Singleton.GetHashCode(obj.dirs);
#pragma warning restore CS0612 // 'Eq<DirI, Eq>' is obsolete
			//throw new NotImplementedException();
		}



		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Eq>' is obsolete
				return nilnul._obj.Singleton<Eq>.Instance;
#pragma warning restore CS0612 // 'Singleton<Eq>' is obsolete
			}
		}


	}
}
