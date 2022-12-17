using nilnul.obj;
using System;

namespace nilnul.fs.address.be
{
	public class Vow2
		: nilnul.obj.be.Vow4<nilnul.fs.AddressI1>,
		nilnul.fs.address.VowI1
	{
		public Vow2(BeI1<AddressI1> be) : base(be)
		{
		}

		public Vow2(Predicate<AddressI1> predicate) : base(predicate)
		{
		}

		public Vow2(Func<AddressI1, bool> func) : base(func)
		{
		}
	}
}
