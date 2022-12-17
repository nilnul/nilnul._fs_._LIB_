using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be
{
	public class En<TBe> : nilnul.obj.be.en_.BeDefaulted1<nilnul.fs.FileI, TBe>
		where TBe : nilnul.fs.file.BeI, new()
	{
		public En(FileI val) : base(val)
		{
		}

		public En(nilnul.fs.address_.SpearI spear):this(new File(spear) )
		{

		}
		public En(string spear):this( new nilnul.fs.File(spear) )
		{

		}
	}
}
