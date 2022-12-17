using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.addresses_.disjoint_.endMatters
{
	static public class ExtensionsX
	{
		static public nilnul.fs.AddressI NonstrictSupAsNulable(
			this
			nilnul.fs.addresses_.disjoint_.EndMatters disjoint
				,
			nilnul.fs.AddressI address

		)
		{


			return disjoint.Where(
				a => nilnul.fs.address.re_.Sup.Singleton.re(a, address)
			).SingleOrDefault();

		}
	}
}
