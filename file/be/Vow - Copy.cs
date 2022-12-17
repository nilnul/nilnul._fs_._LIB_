using System;

namespace nilnul.fs.file.be
{
	[Obsolete()]
	public class Vow<TBe, TVow> : nilnul.obj.be.vow_.xpn_.unacceptable_.be_.Defaultable<nilnul.fs.FileI, TBe, TVow>
		,
		nilnul.fs.file.VowI
		where TBe : nilnul.fs.file.BeI, new()
		where TVow : nilnul.fs.file.VowI
	{

	}

	[Obsolete()]
	public class Vow<TVow> :
		nilnul.obj.be.vow_.xpn_.unacceptable_.be_.General<nilnul.fs.FileI, TVow>
		,
		nilnul.fs.file.VowI

		where TVow : nilnul.fs.file.VowI
	{
		public Vow(nilnul.fs.file.BeI be) : base(be)
		{

		}
	}


}
