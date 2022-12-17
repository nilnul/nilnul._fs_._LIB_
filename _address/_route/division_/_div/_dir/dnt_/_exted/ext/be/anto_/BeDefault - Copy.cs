using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.be.anto_
{
	public class BeDefault<TBe>
		: ext.be.Anto
		where TBe : nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.BeI, new()
	{
		public BeDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeDefault<TBe> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<BeDefault<TBe>>.Instance;
			}
		}
		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TBe>>.Instance;
			}
		}



	}
}
