using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.vow
{
	[Obsolete()]
	public class Ed<TVow> : nilnul.obj.vow.Ed<nilnul.fs.Folder, TVow>
		where TVow : VowI, new()
	{
		public Ed(Folder val) : base(val)
		{
		}
	}
}
