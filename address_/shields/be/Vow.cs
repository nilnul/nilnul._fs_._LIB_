using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.be
{
	[Obsolete()]
	public class Vow<T>
		:
		nilnul.obj.be.Vow1<nilnul.fs.address_.ShieldsI, T>
		,
		nilnul.fs.address_.shields.VowI
		where T:BeI,new()
	{
	}
}
