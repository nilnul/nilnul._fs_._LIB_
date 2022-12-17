using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.sprig
{
	[Obsolete()]
	static public class _EqX
	{
		static public bool Eq(SprigI x, SprigI y) {
			return document.Eq.Singleton.Equals(x.document, y.document);
		}
		
	}
	[Obsolete()]
	public class Eq : IEqualityComparer<SprigI>
	{
		public bool Equals(SprigI x, SprigI y)
		{
			return _EqX.Eq(x,y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(SprigI obj)
		{
			return nilnul.fs._address.document.Eq.Singleton.GetHashCode(obj.document);
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
