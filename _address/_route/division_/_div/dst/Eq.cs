using System.Collections.Generic;

namespace nilnul.fs._address.dst
{
	public class Eq : IEqualityComparer<DstI>
	{
		public bool Equals(DstI x, DstI y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.ToString(), y.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(DstI obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());
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
