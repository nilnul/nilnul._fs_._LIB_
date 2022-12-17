using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.containers.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<nilnul.fs.address_.ContainersI, TVow>
		where TVow:nilnul.fs.address_.containers.VowI,new()
	{
		public En(ContainersI val) : base(val)
		{
		}
	}
}
