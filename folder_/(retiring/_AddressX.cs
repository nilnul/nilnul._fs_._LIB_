using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	[Obsolete()]
	static public class _AddressX
	{
		static public nilnul.fs.FolderI1 FroAddress(nilnul.fs.AddressI1 address) {
			return new nilnul.fs.Folder1(
				nilnul.fs.address_.Container1.FroAddress(address)
			);
		}

		static public nilnul.fs.FolderI1 FroAddress(string address) {
			return FroAddress(
				nilnul.fs.Address1.Parse(address)
			);
		}

	}
}
