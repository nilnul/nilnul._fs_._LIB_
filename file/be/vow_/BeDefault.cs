using nilnul.obj;
using System;

namespace nilnul.fs.file.be.vow_
{
	public class BeDefault<TBe> : file.be.Vow2

		where TBe : nilnul.fs.file.BeI, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}