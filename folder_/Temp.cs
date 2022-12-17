using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	[Obsolete(nameof(_TmpX))]
	public class _TempX
	{
		static public nilnul.fs.Folder Get() {
			return nilnul.fs.Folder.Parse( System.IO.Path.GetTempPath());
		}

	}
}
