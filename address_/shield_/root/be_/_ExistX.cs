using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield_.root.be_
{
	static public class _ExistX
	{
		static public bool Be(address_.shield_.Vol1 vol) {
			return System.IO.Directory.Exists(
				vol.ToString()
			);
		}
		static public bool Be(_address.VolI vol) {
			return Be(new Vol1(vol));
		}

		public static bool Be(ShieldI obj)
		{
			return Be(obj.vol);
			//throw new NotImplementedException();
		}
	}
}
