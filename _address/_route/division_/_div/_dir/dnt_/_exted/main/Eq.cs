using System.Collections.Generic;

namespace nilnul.fs._address.doc_._exted.main
{
	public class Eq
		: IEqualityComparer<Main>
	{
		public bool Equals(Main x, Main y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
				x.en,
				y.en
			);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Main obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.en);
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
