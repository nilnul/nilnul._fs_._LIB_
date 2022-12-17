using nilnul.obj;
using System;

namespace nilnul.fs.address_.shield.be
{
	public class Vow1<TShield>
		:
		nilnul.obj.be.Vow4<TShield>
		,
		nilnul.fs.address_.shield.VowI<TShield>

		where TShield : nilnul.fs.address_.ShieldI1
		//where TBe : nilnul.fs.address_.shield.BeI<TShield>
	{
		public Vow1(BeI1<TShield> be) : base(be)
		{
		}

		public Vow1(Predicate<TShield> predicate) : base(predicate)
		{
		}

		public Vow1(Func<TShield, bool> func) : base(func)
		{
		}

		
	}
}
