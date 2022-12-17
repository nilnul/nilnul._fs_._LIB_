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
	static public class _SupProX
	{
		static public bool Re(route_.StemI2 x, route_.StemI2 y) {
			return _SupX2.Re(x, y) && route_.stem.re_._NeX.Re(x, y);
		}

	}

	public class SupPro : ReI2
	{
		public bool re(StemI2 a, StemI2 b)
		{
			return _SupProX.Re(a,b);
			//throw new NotImplementedException();
		}


		static public SupPro Singleton
		{
			get
			{
				return nilnul._obj.Singleton<SupPro>.Instance;
			}
		}


	}
}
