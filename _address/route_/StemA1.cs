namespace nilnul.fs._address.route_
{
	public abstract class StemA1 : StemI1
	{
		public abstract _route.division_.DivI div { get; }
		public _route.DivisionI division { get { return div; } }

		static public StemI1 _Of_assumeStem(RouteI1 route)
		{
			switch (route)
			{
				case route_.StemI1 stem:
					return stem;
				default:
					return Stem1.Parse(route.ToString());

					break;
			}
		}
	}

}
