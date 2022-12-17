using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dst
{
	public class Eq1 : IEqualityComparer<DstI>
	{
		public bool Equals(DstI x, DstI y)
		{
			return nilnul.fs._address._dst.denote.Eq.Singleton.Equals(x.denote, y.denote);
			//return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(), y.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(DstI obj)
		{
			return nilnul.fs._address._dst.denote.Eq.Singleton.GetHashCode(obj.denote);
			//return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());
			//throw new NotImplementedException();
		}


		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1>.Instance;
			}
		}


	}
}
