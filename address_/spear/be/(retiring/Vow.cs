using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.element.be
{
	[Obsolete()]
	public class Vow<T>
		:nilnul.obj.be.Vow1<nilnul.fs.address_.ElementI1,T>
		,nilnul.fs.address_.element.VowI
		where T:nilnul.fs.address_.element.BeI1,new()
	{
	}
}
