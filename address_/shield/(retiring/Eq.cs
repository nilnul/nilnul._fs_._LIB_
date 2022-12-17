using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield
{
	[Obsolete()]
	public class Eq : IEqualityComparer<nilnul.fs.address_.ShieldI>
	{
		public bool Equals(ShieldI x, ShieldI y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol,y.vol)
				&&
				nilnul.fs._address.route_.stem.Eq1.Singleton.Equals(
					x.stem,y.stem
				)
			;

		}

		

		public int GetHashCode(ShieldI obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route_.stem.Eq1.Singleton.GetHashCode(obj.stem)
			;

		}



		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}



	}
}
