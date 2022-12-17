using nilnul.obj;
using System;

namespace nilnul.fs.address_.shield.be.vow_
{
	public class BeDefault<TShield, TBe>
		: be.Vow1<TShield>
		,
		nilnul.fs.address_.shield.VowI<TShield>

		where TShield : nilnul.fs.address_.ShieldI1
		where TBe : nilnul.fs.address_.shield.BeI<TShield>, new()
	{
		public BeDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeDefault<TShield, TBe> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<BeDefault<TShield, TBe>>.Instance;
			}
		}
		static public BeDefault<TShield, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TShield, TBe>>.Instance;
			}
		}


	}
}
