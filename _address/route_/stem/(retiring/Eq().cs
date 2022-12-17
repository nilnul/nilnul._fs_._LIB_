using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem
{
	[Obsolete()]
	static public class _EqX
	{
		static public bool Eq(StemI x, StemI y) {
			return div.Eq.Singleton.Equals(x.div, y.div);
		}
		static public bool Eq(Stem x, Stem y) {
			return div.Eq1.Singleton.Equals(
				Div1.Parse( 
					x.en.division.ToString()
				),
				Div1.Parse(y.en.division.ToString())
			);
		}
	}
	[Obsolete()]
	public class Eq : IEqualityComparer<StemI>
	{
		public bool Equals(StemI x, StemI y)
		{
			return _EqX.Eq(x,y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(StemI obj)
		{
			return nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div);
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
