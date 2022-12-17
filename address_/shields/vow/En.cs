using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<nilnul.fs.address_.ShieldsI, TVow>
		where TVow:nilnul.fs.address_.shields.VowI,new()
	{
		public En(ShieldsI val) : base(val)
		{
		}
	}
}
