using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	[Obsolete()]
	static public class _ParentDivisionX
	{
		static public nilnul.fs.FolderI1 CreateFolder(nilnul.fs.FolderI1 parent, nilnul.fs._address.DivisionI division) {
			return new nilnul.fs.Folder1(
				nilnul.fs.address_.container_._ContainerDivisionX.CreateContainer(parent.container,division)
			);
		}

		static public nilnul.fs.FolderI1 CreateFolder(nilnul.fs.FolderI1 parent, string division) {
			return CreateFolder(parent, _address.DivisionX.Parse(division));
		}

	}
}
