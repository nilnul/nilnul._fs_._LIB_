using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir
{
	[Obsolete()]
	public class Eq : 
		IEqualityComparer<DirI>
		,
		
		IEqualityComparer<DirName>
	{
		public bool Equals(DirName x, DirName y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.avowed, y.avowed);
			//throw new NotImplementedException();
		}
		public bool Equals(DirI x, DirI y)
		{
			return dst.Eq.Singleton.Equals(x.dst, y.dst);

			//throw new NotImplementedException();
		}

		public int GetHashCode(DirName obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.avowed);
			//throw new NotImplementedException();
		}


		public int GetHashCode(DirI obj)
		{
			return dst.Eq.Singleton.GetHashCode(obj.dst);

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
