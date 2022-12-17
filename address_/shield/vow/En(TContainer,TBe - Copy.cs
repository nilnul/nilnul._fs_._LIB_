namespace nilnul.fs.address_.shield.vow
{
	public class Ee<TShield, TVow>
		:
		nilnul.obj.vow.Ee1<TShield, TVow>
		where TShield : ShieldI1
		where TVow : nilnul.fs.address_.shield.VowI<TShield>
	{
		public Ee(TShield val, TVow vow) : base(val,vow)
		{
		}
	}
}
