using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.directory
{
	[Obsolete()]
	public class Eq :
		_address.div.Eq,

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

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
