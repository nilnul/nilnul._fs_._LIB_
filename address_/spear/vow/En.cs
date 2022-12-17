using System;

namespace nilnul.fs.address_.spear.vow
{
	[Obsolete(
		nameof(Ee)
	)]
	public class En<T> : nilnul.vow.En<nilnul.fs.address_.SpearI, T>
		where T : nilnul.fs.address_.spear.VowI, new()
	{
		public En(SpearI val) : base(val)
		{
		}
		public En(string s) : this(new nilnul.fs.address_.Spear(s))
		{

		}
	}
}
