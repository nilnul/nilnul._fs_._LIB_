using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.child_.nonlink.dir_.nonlink_.empty1namesakes
{
	static public class _DelX
	{
		static public void Del_containerAssumeNonlink(
			nilnul.fs.folder_.ParentDir child
		) {
			_Empty1namesakeesX.Dirs_folderAssumeNonlink(child).Each(
				dir=>
				nilnul.fs.folder.dir._DropX.Drop(
					child,dir
				)

			);
		}
	}
}
