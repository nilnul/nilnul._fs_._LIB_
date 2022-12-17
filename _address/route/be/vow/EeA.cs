using System;

namespace nilnul.fs._address.route.be.vow
{
	/*extern alias obj;*/
	[Obsolete()]
	public class EeA<TVow> :
		/*obj::*/nilnul.obj.vow.En<RouteI, TVow>
		where TVow :
		/*obj::*/nilnul.obj.VowI<RouteI>, new()
	{
		public EeA(RouteI val) : base(val)
		{
		}
	}
}
