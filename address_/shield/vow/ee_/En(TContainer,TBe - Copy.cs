namespace nilnul.fs.address_.shield.vow.ee_
{
	public class VowDefault<TShield, TVow>
		:
		vow.Ee<TShield, TVow>
		where TShield : ShieldI1
		where TVow : nilnul.fs.address_.shield.VowI<TShield>, new()
	{
		public VowDefault(TShield val) :

			base(
				val
				, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
