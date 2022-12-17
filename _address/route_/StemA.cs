using System;

namespace nilnul.fs._address.route_
{
	[Obsolete()]
	public abstract class StemA : StemI
	{
		public abstract DivI div { get; }
		public DivisionI division { get { return div; } }

		static public StemI Ov_assumeStem(RouteI route)
		{
			switch (route)
			{
				case route_.StemI stem:
					return stem;
				default:
					return Stem.Parse(route.ToString());

					break;
			}
		}
	}

}
