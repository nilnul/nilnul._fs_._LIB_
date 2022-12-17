using nilnul.obj;
using System;

namespace nilnul.fs.address.be.vow_
{
	[Obsolete()]
	public class BeDefault<TBe>
		:
		nilnul.fs.address.be.Vow1,
		nilnul.fs.address.VowI
		where TBe : nilnul.fs.address.BeI, new()
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
