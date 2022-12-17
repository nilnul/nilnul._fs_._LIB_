using nilnul.obj;
using System;

namespace nilnul.fs.address.be.vow_
{
	public class BeDefault1<TBe>
		:
		nilnul.fs.address.be.Vow2,
		nilnul.fs.address.VowI1
		where TBe : nilnul.fs.address.BeI1, new()
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
