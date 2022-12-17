using System;

namespace nilnul.fs.address_.shield.vow
{
	[Obsolete()]
	public class En<T> : nilnul.obj.vow.En<nilnul.fs.address_.ShieldI, T>
		where T : nilnul.fs.address_.shield.VowI1, new()
	{
		public En(ShieldI val) : base(val)
		{
		}
	}
}
