using System;

namespace nilnul.fs.address_.spear.be
{
	[Obsolete()]
	public class Vow<T>
		: nilnul.obj.be.Vow2<nilnul.fs.address_.SpearI, T>
		,
		nilnul.fs.address_.spear.VowI
		where T : nilnul.fs.address_.spear.BeI, new()
	{
	}

	//public class Vow<T,TXpn>
	//	:nilnul.obj.be.Vow2<nilnul.fs.address_.SpearI,T,>
	//	,
	//	nilnul.fs.address_.spear.VowI
	//	where T:nilnul.fs.address_.spear.BeI,new()
	//{
	//}

}
