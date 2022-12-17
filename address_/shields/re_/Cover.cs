using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields.re_
{
	public class Cover : ReI
	{
		public bool re(ShieldsI a, ShieldsI b)
		{
			return b.All(y => shields._CoverX.Cover(a, y));
			//throw new NotImplementedException();
		}
		public bool re(IEnumerable<ShieldI> a, IEnumerable<ShieldI> b)
		{
			return b.All(y => shields._CoverX.Cover(a, y));

		}

		public bool re_ofAddresses(IEnumerable<string> a, IEnumerable<string> b)
		{
			return b.All(y => shields._CoverX.Cover_inAddress(a, y));

		}


		static public Cover Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Cover>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Cover>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Cover>' is obsolete: 'Singleton'
			}
		}

	}
}
