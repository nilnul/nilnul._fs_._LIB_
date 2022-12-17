using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// one is the parent of the other or equal to the other. in other words, one nonstrictly contains the other.
	/// </summary>
	/// 
	[Obsolete()]
	static public class _SupX
	{
		static public bool Re(route_.Stem x, route_.Stem y) {
			return stem._EqX.Eq( co_._SharedStubX.Co(x,y) ,x);
		}
		static public bool Re(route_.StemI x, route_.StemI y) {
			return stem._EqX.Eq( co_._SharedStubX.Co(x,y) ,x);
		}

	}
	[Obsolete()]

	public class Sup : ReI
	{
		public bool re(StemI a, StemI b)
		{
			return _SupX.Re(a,b);
			//throw new NotImplementedException();
		}

		static public Sup Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Sup>.Instance;
			}
		}

	}
}
