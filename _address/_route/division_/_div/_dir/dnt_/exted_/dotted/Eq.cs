using System.Collections.Generic;

namespace nilnul.fs._address.doc_.exted_.dotted
{
	public class Eq
		: IEqualityComparer<Dotted>
	{
		public bool Equals(Dotted x, Dotted y)
		{
			return doc_._exted.main.Eq.Singleton.Equals(x.main, y.main)
				&&
				doc_._exted.ext_.ovAftDot.Eq.Singleton.Equals(x.extOvAftDot, y.extOvAftDot)
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Dotted obj)
		{
			return doc_._exted.main.Eq.Singleton.GetHashCode(obj.main)
				^
				doc_._exted.ext_.ovAftDot.Eq.Singleton.GetHashCode(obj.extOvAftDot)
			;
			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Eq>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
			}
		}

	}
}
