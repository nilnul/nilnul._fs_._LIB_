using System;

namespace nilnul.fs.address_.shield.be
{

	[Obsolete()]
	public class Vow<T>
		:
		nilnul.obj.be.Vow1<nilnul.fs.address_.ShieldI, T>
		,
		nilnul.fs.address_.shield.VowI1
		where T : nilnul.fs.address_.shield.BeI1, new()
	{
	}
}
