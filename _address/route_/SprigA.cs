using System;

namespace nilnul.fs._address.route_
{
	[Obsolete()]
	public abstract class SprigA : SprigI
	{
		public abstract DocumentI document { get; }
		public DivisionI division { get { return document; } }

		static public SprigI Downcast(RouteI route)
		{
			switch (route)
			{
				case SprigI sprig:
					return sprig;

				default:
					return Sprig.Parse(route.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}
	}



}