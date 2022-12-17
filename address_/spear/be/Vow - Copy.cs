using nilnul.obj;
using System;

namespace nilnul.fs.address_.spear.be
{
	public class Vow1
		: nilnul.obj.be.Vow4<nilnul.fs.address_.SpearI1>
		
		,
		nilnul.fs.address_.spear.VowI2

	{
		public Vow1(BeI1<SpearI1> be) : base(be)
		{
		}

		public Vow1(Predicate<SpearI1> predicate) : base(predicate)
		{
		}

		public Vow1(Func<SpearI1, bool> func) : base(func)
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
