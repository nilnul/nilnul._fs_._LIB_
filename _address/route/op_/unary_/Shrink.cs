namespace nilnul.fs._address.route.op_.unary_
{
	public class Shrink : UnaryI
	{
		public RouteI op(RouteI par)
		{
			return RouteA.Ov(
				nilnul.fs._address.division.op_.unary_.Shrink.Singleton.op(
					par.division
				)
			);
			//throw new NotImplementedException();
		}

		static public Shrink Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Shrink>.Instance;
			}
		}

	}
}
