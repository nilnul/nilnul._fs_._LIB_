using System;

namespace nilnul.fs.address_.shield.be._vow_
{
	[Obsolete()]
	public class Shield<TShield, TBe>
		: nilnul.be.Vow<TShield, TBe>
		,
		nilnul.fs.address_.shield._vow_.ShieldI<TShield>

		where TShield : nilnul.fs.address_.ShieldI
		where TBe : nilnul.fs.address_.shield._be_.ShieldI<TShield>, new()
	{

	}
}
