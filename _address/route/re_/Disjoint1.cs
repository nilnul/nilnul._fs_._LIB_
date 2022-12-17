namespace nilnul.fs._address.route.re_
{
	public class Disjoint : route.ReI
	{
		public bool re(RouteI a, RouteI b)
		{
			return route_.stem.re_._DisjointX2.Re(
				route_.stem_._RouteX2.Fro(a)
				,
				route_.stem_._RouteX2.Fro(b)
			);

		}

		static public Disjoint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Disjoint>.Instance;
			}
		}

	}
}
