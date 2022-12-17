using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be
{
	static public partial class _ExtensionsX
	{
		static public bool Be(
			this nilnul.fs.folder.BeI1 be
			,
			nilnul.fs.address_.ShieldI1 shield
		) {
			return be.be(
				new nilnul.fs.Folder1(shield)
			);
		}

		static public bool Be(this nilnul.fs.folder.BeI1 be, nilnul.fs.AddressI1 address)
		{
			return be.be( new nilnul.fs.Folder1(address));
		}


		static public bool Be_ofAddress(this nilnul.fs.folder.BeI1 be, string address)
		{
			return Be(be, nilnul.fs.AddressA1.Parse(address));
		}


	}
}
