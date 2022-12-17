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
	static public class _SupX1
	{
		
		static public bool Re(route_.StemI1 x, route_.StemI1 y) {
			return stem._EqX1.Eq( co_._SharedStubX1.Co(x,y) ,x);
		}

	}

	[Obsolete()]
	public class Sup1 : ReI1
	{
		public bool re(StemI1 a, StemI1 b)
		{
			return _SupX1.Re(a,b);
			//throw new NotImplementedException();
		}


		static public Sup1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Sup1>.Instance;
			}
		}


	}
}
