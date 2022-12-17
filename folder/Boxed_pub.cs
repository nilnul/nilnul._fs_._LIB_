using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder
{
	public class Boxed_pub : nilnul.obj.Box_pub<nilnul.fs.FolderI>
	{
		public Boxed_pub(FolderI val) : base(val)
		{
		}
	}
}
