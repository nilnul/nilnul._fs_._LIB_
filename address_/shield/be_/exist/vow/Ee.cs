namespace nilnul.fs.address_.shield.be_.exist.vow
{
	public class Ee<TShield>
		:
		nilnul.fs.address_.shield.vow.ee_.VowDefault<
			TShield
			,
			nilnul.fs.address_.shield.be_.exist.Vow<TShield>
		>
		where TShield : nilnul.fs.address_.ShieldI1
	{
		public Ee(TShield val) : base(val)
		{
		}
	}
}
