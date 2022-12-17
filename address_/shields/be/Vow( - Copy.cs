using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.containers.be
{
	[Obsolete()]
	public class Vow<T>
		:
		nilnul.obj.be.Vow1<nilnul.fs.address_.ContainersI, T>
		,
		nilnul.fs.address_.containers.VowI
		where T:BeI,new()
	{
	}
}
