using System.Collections.Generic;

namespace nilnul.fs._address.route_.stem_.division
{
	public class Eq : IEqualityComparer<DivisionI>
	{
		public bool Equals(DivisionI x, DivisionI y)
		{
			return stem.Eq.Singleton.Equals(stem_._DivisionX._Stem(x), stem_._DivisionX._Stem(y));
			//throw new NotImplementedException();
		}
		public bool Equals(string x, string y)
		{
			return Equals(DivisionA.Parse(x), DivisionA.Parse(y));
		}

		public int GetHashCode(DivisionI obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Eq>' is obsolete
				return nilnul._obj.Singleton<Eq>.Instance;
#pragma warning restore CS0612 // 'Singleton<Eq>' is obsolete
			}
		}

	}
}
