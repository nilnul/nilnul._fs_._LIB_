namespace nilnul.fs._address.route_
{

	public abstract class SprigA1 : SprigI1
	{
		public abstract _route.division_.div.DntedI  denotation { get; }
		public _route.DivisionI division { get { return denotation; } }

		static public SprigI1 Of(RouteI1 route)
		{
			switch (route)
			{
				case SprigI1 sprig:
					return sprig;

				default:
					return Sprig1.Parse(route.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}
	}



}