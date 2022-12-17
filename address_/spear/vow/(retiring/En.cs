using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.element.vow
{
	public class En<T> : nilnul.obj.vow.En<nilnul.fs.address_.ElementI1, T>
		where T : nilnul.fs.address_.element.VowI, new()
	{
		public En(ElementI1 val) : base(val)
		{
		}
	}
}
