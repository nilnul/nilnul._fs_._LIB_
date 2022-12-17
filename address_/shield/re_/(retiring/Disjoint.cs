using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	/// 
	[Obsolete()]
	static public class _DisjointX
	{
		static public bool Re(nilnul.fs.address_.ShieldI a, nilnul.fs.address_.ShieldI b) {
			if ( nilnul.fs._address.vol.Eq.Singleton.Equals( a.vol , b.vol))
			{
				return nilnul.fs._address.route_.stem.re_._DisjointX1.Be( 
					a.stem,b.stem
				);
			}
			return false;
		}

		

	}
}
