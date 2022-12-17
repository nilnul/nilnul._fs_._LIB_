using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt_.fS_.location
{
	public class _ExploreX
	{
		static public void Sel(string s) {
			var address = nilnul.fs.address.nulable._ParseX.Parse(s);
			if (address==null)
			{
				return;

			}
			nilnul.fs.address._ExploreX.Sel(address);
		}
	}
}
