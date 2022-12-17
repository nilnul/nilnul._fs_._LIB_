using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.Ed<nilnul.fs.FolderI1, TVow>
		where TVow : VowI1, new()
	{
		public En(FolderI1 val) : base(val)
		{
		}
	}
}
