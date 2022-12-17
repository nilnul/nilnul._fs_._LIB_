using nilnul.obj;
using System;

namespace nilnul.fs.address_.shield.be
{
	public class Vow2
		:
		Vow1<nilnul.fs.address_.ShieldI1>
		,
		nilnul.fs.address_.shield.VowI2

	{
		public Vow2(BeI1<ShieldI1> be) : base(be)
		{
		}

		public Vow2(Predicate<ShieldI1> predicate) : base(predicate)
		{
		}

		public Vow2(Func<ShieldI1, bool> func) : base(func)
		{
		}
	}
}
