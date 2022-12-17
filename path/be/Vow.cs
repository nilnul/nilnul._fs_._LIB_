using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.be
{
	public class Vow : nilnul.obj.be.Vow4<fs.IPath>
		,
		path.VowI
	{
		public Vow(BeI1<IPath> be) : base(be)
		{
		}

		public Vow(Predicate<IPath> predicate) : base(predicate)
		{
		}

		public Vow(Func<IPath, bool> func) : base(func)
		{
		}
	}
}
