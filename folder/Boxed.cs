using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder
{
	public class Boxed : nilnul.obj.Box1<nilnul.fs.FolderI>
	{
		public Boxed(FolderI val) : base(val)
		{
		}
	}
}
