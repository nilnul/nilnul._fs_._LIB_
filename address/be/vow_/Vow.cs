using System;

namespace nilnul.fs.address.be
{
	[Obsolete()]
	public class Vow<TBe>
#pragma warning disable CS0612 // 'Vow1<AddressI, TBe>' is obsolete
		: nilnul.obj.be.Vow1<nilnul.fs.AddressI, TBe>
#pragma warning restore CS0612 // 'Vow1<AddressI, TBe>' is obsolete
		,
		nilnul.fs.address.VowI
		where TBe : nilnul.fs.address.BeI, new()
	{
	}
}
