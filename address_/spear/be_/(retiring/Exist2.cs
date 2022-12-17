using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be_
{
	[Obsolete(nameof(_OccupiedX))]

	static public class _ExistX {
		static public bool _Be(string spear) {
			return System.IO.Directory.Exists(spear) || System.IO.File.Exists(spear);

		}
	}

	[Obsolete(nameof(Occupied))]
	public class Exist
		: nilnul.fs.address_.spear.BeI
	{
		public bool be(SpearI1 obj)
		{
			return _ExistX._Be(obj.ToString());
		}



		static public Exist Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Exist>.Instance;
			}
		}




	}
}
