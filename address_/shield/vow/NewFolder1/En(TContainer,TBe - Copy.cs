using System;

namespace nilnul.fs.address_.shield.vow._en_
{
	[Obsolete()]
	public class Shield<TShield, TVow>
		:
		nilnul.obj.vow.En<TShield, TVow>
		where TShield : ShieldI
		where TVow : nilnul.fs.address_.shield._vow_.ShieldI<TShield>, new()
	{
		public Shield(TShield val) : base(val)
		{
		}
	}
}
