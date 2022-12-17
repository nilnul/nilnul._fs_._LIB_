using nilnul.obj;
using System;

namespace nilnul.fs.address_.shield.be.vow_
{
	[Obsolete()]
	public class BeDefault<TBe>
		: shield.be.Vow1


		where TBe : nilnul.fs.address_.shield.BeI1, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<TBe>>.Instance;
			}
		}



	}
}
