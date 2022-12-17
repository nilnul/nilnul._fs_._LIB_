namespace nilnul.fs._address.route.re_
{
	/// <summary>
	/// </summary>
	public class Sub : ReI
	{
		public bool re(RouteI x, RouteI y)
		{
			return route_.stem.re_.Sub.Singleton.re(
				route_.stem_._RouteX2.Fro(x)
				,
				route_.stem_._RouteX2.Fro(y)
			);

			//throw new NotImplementedException();
		}


		static public Sub Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sub>.Instance;
			}
		}


	}
}
