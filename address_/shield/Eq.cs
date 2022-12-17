using System.Collections.Generic;

namespace nilnul.fs.address_.shield
{
	public interface EqI:IEqualityComparer<nilnul.fs.address_.ShieldI>{

	}
	public class Eq : IEqualityComparer<nilnul.fs.address_.ShieldI>
	{
		public bool Equals(ShieldI x, ShieldI y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol, y.vol)
				&&
				nilnul.fs._address.route_.stem.Eq.Singleton.Equals(
					x.stem, y.stem
				)
			;

		}



		public int GetHashCode(ShieldI obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route_.stem.Eq.Singleton.GetHashCode(obj.stem)
			;

		}



		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}



	}
}
