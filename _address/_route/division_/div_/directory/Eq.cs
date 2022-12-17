using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_.div_.directory
{
	public class Eq :
		_address._route.division_.div.Eq,

		IEqualityComparer<DirectoryI>
	{
		public bool Equals(DirectoryI x, DirectoryI y)
		{
			return base.Equals(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(DirectoryI obj)
		{
			return base.GetHashCode(obj);
			throw new NotImplementedException();
		}


		static public Eq Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Eq>.Instance;
			}
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
