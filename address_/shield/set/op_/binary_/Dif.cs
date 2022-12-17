using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.set.op_.binary_
{
	public class Dif
		:
		BinaryI
	{
		public Set op(Set par, Set par1)
		{
			var r = new Set(par);
			r.ExceptWith(par1);
			return r;
			//throw new NotImplementedException();
		}

		public Set op(IEnumerable<ShieldI> par, IEnumerable<ShieldI> par1)
		{
			return op(
				new Set(par)
				,
				new Set(par1)
			);
		}

		public Set op_ofAddresses(IEnumerable<string> x, IEnumerable<string> y)
		{
			return op(
				x.Select(xx => nilnul.fs.address_.shield_._AddressX1.Create(xx))
				,
				y.Select(yy => nilnul.fs.address_.shield_._AddressX1.Create(yy))
				);
		}

		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
