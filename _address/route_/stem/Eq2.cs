using System.Collections.Generic;

namespace nilnul.fs._address.route_.stem
{
	static public class _EqX
	{
		static public bool Eq(StemI x, StemI y)
		{
			return div.Eq.Singleton.Equals(x.div, y.div);
		}

	}

	public class Eq : IEqualityComparer<StemI>
	{
		public bool Equals(StemI x, StemI y)
		{
			return _EqX.Eq(x, y);
			//throw new NotImplementedException();
		}

		public bool Equals(string x, string y)
		{
			return Equals(Stem.Parse(x), Stem.Parse(y));
		}


		public int GetHashCode(StemI obj)
		{
			return nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div);
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
