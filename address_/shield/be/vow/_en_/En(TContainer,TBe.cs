namespace nilnul.fs.address_.shield.be.vow._en_
{
	public class Shield<TShield, TBe>
		: nilnul.obj.vow.En<TShield, _vow_.Shield<TShield, TBe>>

		where TShield : ShieldI
		where TBe : nilnul.fs.address_.shield._be_.ShieldI<TShield>, new()
	{
		public Shield(TShield val) : base(val)
		{
		}
	}
}
