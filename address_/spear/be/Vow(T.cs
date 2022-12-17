using nilnul.obj;
using System;

namespace nilnul.fs.address_.spear.be
{
	public class Vow1<TSpear>
		: nilnul.obj.be.Vow4<TSpear>

		
		,
		nilnul.fs.address_.spear.VowI<TSpear>
		where TSpear: nilnul.fs.address_.SpearI1

	{
		public Vow1(BeI1<TSpear> be) : base(be)
		{
		}

		public Vow1(Predicate<TSpear> predicate) : base(predicate)
		{
		}

		public Vow1(Func<TSpear, bool> func) : base(func)
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
