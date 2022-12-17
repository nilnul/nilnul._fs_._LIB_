using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.element
{
	[Obsolete()]
	public class Eq1 : IEqualityComparer<nilnul.fs.address_.ElementI1>
	{
		public bool Equals(ElementI1 x, ElementI1 y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol,y.vol)
				&&
				nilnul.fs._address.route_.sprig._EqX.Eq(
					x.sprig,y.sprig
				)
			;

		}

		public bool Equals(string x, string y)
		{
			return Equals(
				nilnul.fs.address_.Container1.FroAddress(x)
				,
				nilnul.fs.address_.Container1.FroAddress(y)
			);

		}

		public int GetHashCode(ElementI1 obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route_.sprig.Eq.Singleton.GetHashCode(obj.sprig)
			;

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
