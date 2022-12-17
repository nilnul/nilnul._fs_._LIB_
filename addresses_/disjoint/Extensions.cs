using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.addresses_.disjoint
{
	static public class ExtensionsX
	{
		static public nilnul.fs.AddressI NonstrictSupAsNulable(
			this
			nilnul.fs.addresses_.Disjoint disjoint
				,
			nilnul.fs.AddressI address

		)
		{


			return disjoint.boxed.Where(
				a => nilnul.fs.address.re_.Sup.Singleton.re(a, address)
			).SingleOrDefault();

		}
	}
}
