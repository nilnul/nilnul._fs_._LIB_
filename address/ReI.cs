using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address
{
	public interface ReI : nilnul.obj.ReI<nilnul.fs.AddressI>
	{
	}

	static public class ReX
	{
		static public bool Re(this ReI re, string a, string b) {
			return re.re(
				nilnul.fs.AddressA.Parse(a)
				,
				AddressA.Parse(b)
			);
		}

		static public bool Re(this ReI re, string a, nilnul.fs.AddressI b) {
			return re.re(
				nilnul.fs.AddressA.Parse(a)
				,
				(b)
			);
		}

		static public bool Re(this ReI re, nilnul.fs.AddressI a, string b) {
			return re.re(
				(a)
				,
				AddressA.Parse(b)
			);
		}

	}
}
