using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container.re_
{
	/// <summary>
	/// one is not in the other.
	/// </summary>
	static public class _DisjointX
	{
		static public bool Re(nilnul.fs.address_.ContainerI1 a, nilnul.fs.address_.ContainerI1 b) {
			if ( nilnul.fs._address.vol.Eq.Singleton.Equals( a.vol , b.vol))
			{
				return nilnul.fs._address.route_.stem.re_._DisjointX.Be( 
					a.stem,b.stem
				);
			}
			return false;
		}

		static public bool Re(nilnul.fs.address_.volRoute_.Container a, nilnul.fs.address_.volRoute_.Container b) {
			if ( nilnul.fs._address.vol.Eq.Singleton.Equals( a.vol , b.vol))
			{
				return nilnul.fs._address.route_.stem.re_._DisjointX.Be( 
					a.deckedDiv,b.deckedDiv
				);
			}
			return false;
		}

	}
}
