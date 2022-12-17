using System.Collections.Generic;

namespace nilnul.fs._address.doc_._exted.ext_.ovAftDot
{
	public class Eq : IEqualityComparer<OvAftDot>
	{
		public bool Equals(OvAftDot x, OvAftDot y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x.aftDot, y.aftDot);
			//throw new NotImplementedException();
		}


		public int GetHashCode(OvAftDot obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.aftDot);
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
