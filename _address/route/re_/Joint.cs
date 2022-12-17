namespace nilnul.fs._address.route.re_
{
	public class Joint : route.ReI,route.ReI1
	{
		public bool re(RouteI a, RouteI b)
		{
			return _address._route.division.re_.Joint.Singleton.re(
				(a.division)
				,
				(b.division)
			);

		}

		public bool re(RouteI1 a, RouteI1 b)
		{
			return _address._route.division.re_.Joint.Singleton.re(
				(a.division)
				,
				(b.division)
			);

		}

		static public Joint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint>.Instance;
			}
		}

	}
}
