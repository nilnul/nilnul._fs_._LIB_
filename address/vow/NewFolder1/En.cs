using System;

namespace nilnul.fs.address.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<nilnul.fs.AddressI, TVow>
		where TVow : VowI, new()
	{
		public En(AddressI val) : base(val)
		{
		}
	}
}
