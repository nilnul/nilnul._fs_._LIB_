using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division_.nonRt
{
	public class Eq : division.Eq, IEqualityComparer<NonRt>
	{
		public bool Equals(NonRt x, NonRt y)
		{
			return base.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(NonRt obj)
		{
			return base.GetHashCode(obj);
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
