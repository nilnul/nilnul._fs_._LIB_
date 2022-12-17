using System.Collections.Generic;

namespace nilnul.fs._address.doc_.exted_.noDot
{
	public class Eq : IEqualityComparer<
		NoDot
	>
	{
		public bool Equals(NoDot x, NoDot y)
		{
			return nilnul.fs._address._dst.denote.Eq.Singleton.Equals(x.denote, y.denote);
			//throw new NotImplementedException();
		}

		public int GetHashCode(NoDot obj)
		{
			return nilnul.fs._address._dst.denote.Eq.Singleton.GetHashCode(obj.denote);
			//throw new NotImplementedException();
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
