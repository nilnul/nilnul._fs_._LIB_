using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.vow
{
	[Obsolete()]
	public class En1<TVow> : nilnul.obj.vow.En<nilnul.fs.FolderI1, TVow>
		where TVow : VowI1, new()
	{
		public En1(FolderI1 val) : base(val)
		{
		}
	}
}
