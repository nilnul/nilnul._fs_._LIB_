using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be.en_
{
	public class BeDefaulted<TBe>
		: spear.be.En
		where TBe : nilnul.fs.address_.spear.BeI, new()
	{
		public BeDefaulted(SpearI obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}
