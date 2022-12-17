namespace nilnul.fs._address.route.be.vow
{
	/*extern alias obj;*/
	public class EnA<TVow> :
		/*obj::*/nilnul.obj.vow.En<RouteI, TVow>
		where TVow :
		/*obj::*/nilnul.obj.VowI<RouteI>, new()
	{
		public EnA(RouteI val) : base(val)
		{
		}
	}
}
