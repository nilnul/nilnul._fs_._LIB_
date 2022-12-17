using nilnul.obj;
using System;

namespace nilnul.fs.address_.shield.be
{
	[Obsolete()]
	public class Vow1
		:
		nilnul.obj.be.Vow4<nilnul.fs.address_.ShieldI>
		,
		nilnul.fs.address_.shield.VowI1

	{
		public Vow1(BeI1<ShieldI> be) : base(be)
		{
		}

		public Vow1(Predicate<ShieldI> predicate) : base(predicate)
		{
		}

		public Vow1(Func<ShieldI, bool> func) : base(func)
		{
		}
	}
}
