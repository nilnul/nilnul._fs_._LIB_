using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be.vow_
{
	public class BeDefault<T,TBe> : spear.be.Vow1<T>
		where TBe : address_.spear.BeI<T>, new()
		where T: nilnul.fs.address_.SpearI1
	{
		public BeDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeDefault<T,TBe> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<BeDefault<T,TBe>>.Instance;
			}
		}
		static public BeDefault<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<T,TBe>>.Instance;
			}
		}




	}
}
