using System.Collections.Generic;

namespace nilnul.fs._address.route
{
	public class Comparer : IComparer<nilnul.fs._address.RouteI>
	{
		public int Compare(RouteI x, RouteI y)
		{
			return nilnul.fs._address.division.Comparer.Singleton.Compare(x.division, y.division);
			//throw new NotImplementedException();
		}

		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}
