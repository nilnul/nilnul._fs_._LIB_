using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir
{
	static public class _DropX
	{
		static public void Drop(nilnul.fs.FolderI container, _address.DirI dir) {
			nilnul.fs.folder.drop_._RecyclableX.Drop(
				new nilnul.fs.address_.shield_.BaseDir(container.address.en, dir)
			);
		}

		static public void Drop_containerOfAddress_childOfDst(string container, string dir) {
			Drop(
				nilnul.fs.Folder.FroAddress(container)
				,
				nilnul.fs._address.Dir.OvDst(dir)
			);
		}

	}
}
