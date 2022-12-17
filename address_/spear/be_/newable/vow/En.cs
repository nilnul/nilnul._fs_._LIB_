using System;

namespace nilnul.fs.address_.spear.be_.newable.vow
{
	[Obsolete()]
	public class En : nilnul.fs.address_.spear.vow.En<Vow>
	{
		public En(nilnul.fs.address_.SpearI val) : base(val)
		{
		}
		public En(nilnul.fs.address_.Spear address) : this((nilnul.fs.address_.SpearI)address)
		{

		}

		public En(string address) : this(new nilnul.fs.address_.Spear(address))
		{

		}
	}
}
