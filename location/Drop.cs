using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location
{
	static public class _DropX
	{
		static public void Drop(nilnul.fs.File0FolderI location) {
			if (location is nilnul.fs.FileI file)
			{
				nilnul.fs.file.del_._RecyclableX.Del(file);
			}
			nilnul.fs.folder._DropX.Vod((nilnul.fs.FolderI)location);
		}
	}
}
