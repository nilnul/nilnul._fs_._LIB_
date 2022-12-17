using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.child_.nonlink.dir_.nonlink_
{
	/// <summary>
	/// these dirs are deletable
	/// </summary>
	static public class _Empty1namesakeesX
	{
		static public IEnumerable<nilnul.fs._address.DirI> Dirs_folderAssumeNonlink(nilnul.fs.folder_.ParentDir child) {

			return nilnul.fs.folder.dirs_._NonlinkX.Dirs(child).Where(
				dir=>
				nilnul.fs.folder.dir.be_._EmptyX.Be(child,dir)
				&&
				nilnul.txt.Eq.Singleton.Equals(
					dir.denote
					,
					child.en.child.denote
				)
			);
		}
	}
}
