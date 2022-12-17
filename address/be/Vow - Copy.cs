using nilnul.obj;
using System;

namespace nilnul.fs.address.be
{
	[Obsolete()]
	public class Vow1
		: nilnul.obj.be.Vow4<nilnul.fs.AddressI>,
		nilnul.fs.address.VowI
	{
		public Vow1(BeI1<AddressI> be) : base(be)
		{
		}

		public Vow1(Predicate<AddressI> predicate) : base(predicate)
		{
		}

		public Vow1(Func<AddressI, bool> func) : base(func)
		{
		}
	}
}
