using System.Collections.Generic;

namespace nilnul.fs._address._route.division_._div._dir.dnt
{
	public class Eq :
		nilnul.obj.eq_.homo_.EqDefault<DntI, string, nilnul.txt.eq_.CaseInsensitive>
		,
		IEqualityComparer<DntI>
		,
		IEqualityComparer<DntI1>


	{
		public Eq() : base(c => c.caption.en)
		{
		}

		public bool eq(string x, string y)
		{
			return eq(new Dnt(x), new Dnt(y));
		}
		public bool _eq_assumeDnt(string x, string y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x, y);
		}

		public bool Equals(DntI1 x, DntI1 y)
		{
			return eq(x.ToString(),y.ToString());
			throw new System.NotImplementedException();
		}

		public int GetHashCode(DntI1 obj)
		{
			return GetHashCode(new Dnt(obj.ToString()));

		}


		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}


	}
}
