using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._dst.name
{
	public class Eq : IEqualityComparer<be_.valid.En>
	{
		public bool Equals(string x, string y) {
			return Equals(new be_.valid.En(x), new be_.valid.En(y));
		}
		private bool _eq(string x, string y) {
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(x, y);
		}

		public bool Equals(be_.valid.En x, be_.valid.En y)
		{
			return _eq(x.en.ToString(),y.en.ToString());
			//throw new NotImplementedException();
		}

		public int GetHashCode(be_.valid.En obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(obj.ToString());

			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

	}
}
