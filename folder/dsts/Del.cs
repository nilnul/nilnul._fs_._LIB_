using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dsts
{
	static public class _DelX
	{
		static public void Del(nilnul.fs.FolderI parent) {
			nilnul.fs.folder._Dsts.Locations(parent).ForEach(
				nilnul.fs.location._DropX.Drop
			);
		}
	}
}
