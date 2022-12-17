using System.Collections.Generic;

using S = nilnul.fs.address_.SpearI;
namespace nilnul.fs.address_.spear
{
	public interface EqI :IEqualityComparer<nilnul.fs.address_.SpearI>{ }
	public class Eq : IEqualityComparer<nilnul.fs.address_.SpearI>
	{
		public bool Equals(S x, S y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol, y.vol)
				&&
				nilnul.fs._address.route_.sprig._EqX1.Eq(
					x.sprig, y.sprig
				)
			;

		}

		public bool Equals(string x, string y)
		{
			return Equals(
				new Spear(x)
				,
				new Spear(y)
			);

		}

		public int GetHashCode(S obj)
		{
			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol)
				&
				nilnul.fs._address.route_.sprig.Eq1.Singleton.GetHashCode(obj.sprig)
			;

		}



		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Eq>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
			}
		}



	}
}
