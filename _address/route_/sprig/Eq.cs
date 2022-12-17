using System.Collections.Generic;
using S = nilnul.fs._address.route_.SprigI;

namespace nilnul.fs._address.route_.sprig
{
	static public class _EqX1
	{
		static public bool Eq(S x, S y)
		{
			return document.Eq.Singleton.Equals(x.document, y.document);
		}

	}
	public class Eq1 : IEqualityComparer<S>
	{
		public bool Equals(S x, S y)
		{
			return _EqX1.Eq(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(S obj)
		{
			return nilnul.fs._address.document.Eq.Singleton.GetHashCode(obj.document);
			//throw new NotImplementedException();
		}


		static public Eq1 Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Eq1>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Eq1>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Eq1>' is obsolete: 'nilnul.obj_.'
			}
		}


	}
}
