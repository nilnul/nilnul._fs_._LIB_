using System;

namespace nilnul.fs.address
{
	[Obsolete()]
	public interface VowI : nilnul.obj.VowI<nilnul.fs.AddressI>
		,
		nilnul.obj.VowI2<nilnul.fs.AddressI>
	{
	}
}
