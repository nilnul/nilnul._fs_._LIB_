using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be.vow_
{
	public class BeDefault1<TBe> : spear.be.Vow1
		where TBe : address_.spear.BeI1, new()
	{
		public BeDefault1() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeDefault1<TBe> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<BeDefault1<TBe>>.Instance;
			}
		}
		static public BeDefault1<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault1<TBe>>.Instance;
			}
		}




	}
}
