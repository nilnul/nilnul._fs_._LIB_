using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container
{
	[Obsolete(nameof(shield.Eq))]
	public class Eq1 : IEqualityComparer<nilnul.fs.address_.ContainerI1>
	{
		public bool Equals(ContainerI1 x, ContainerI1 y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol,y.vol)
				&&
				nilnul.fs._address.route_.stem.Eq1.Singleton.Equals(
					x.stem.ToString(),y.stem.ToString()
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

		public int GetHashCode(ContainerI1 obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route_.stem.Eq.Singleton.GetHashCode(obj.stem)
			;

		}


		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Eq1>.Instance;
			}
		}


	}
}
