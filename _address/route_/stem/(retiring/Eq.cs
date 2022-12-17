using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem
{
	[Obsolete()]
	static public class _EqX1
	{
		static public bool Eq(StemI1 x, StemI1 y)
		{
			return div.Eq1.Singleton.Equals(x.div, y.div);
		}
		
	}
	[Obsolete()]

	public class Eq1 : IEqualityComparer<StemI1>
	{
		public bool Equals(StemI1 x, StemI1 y)
		{
			return _EqX1.Eq(x,y);
			//throw new NotImplementedException();
		}

		public bool Equals(string x, string y) {
			return Equals(Stem1.Parse(x), Stem1.Parse(y));
		}


		public int GetHashCode(StemI1 obj)
		{
			return nilnul.fs._address.div.Eq1.Singleton.GetHashCode(obj.div);
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
