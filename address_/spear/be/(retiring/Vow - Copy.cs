using nilnul.obj;
using System;

namespace nilnul.fs.address_.spear.be
{
	[Obsolete()]
	public class Vow
		: nilnul.obj.be.Vow4<nilnul.fs.address_.SpearI>
		,
		nilnul.fs.address_.spear.VowI
		,
		nilnul.fs.address_.spear.VowI1

	{
		public Vow(BeI1<SpearI> be) : base(be)
		{
		}

		public Vow(Predicate<SpearI> predicate) : base(predicate)
		{
		}

		public Vow(Func<SpearI, bool> func) : base(func)
		{
		}
	}

	//public class Vow<T,TXpn>
	//	:nilnul.obj.be.Vow2<nilnul.fs.address_.SpearI,T,>
	//	,
	//	nilnul.fs.address_.spear.VowI
	//	where T:nilnul.fs.address_.spear.BeI,new()
	//{
	//}

}
