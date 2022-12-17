using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.eq_
{
	public class TargetSame : nilnul.fs.folder.EqI
	{
		public bool Equals(FolderI x, FolderI y)
		{
			return nilnul.fs.folder_.nonlink.Eq.Singleton.eq(x, y);
		}

		public int GetHashCode(FolderI obj)
		{
			return nilnul.fs.folder_.nonlink.Eq.Singleton.GetHashCode(
				nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(obj)
			);
		}


		static public TargetSame Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<TargetSame>.Instance;
			}
		}

	}
}
