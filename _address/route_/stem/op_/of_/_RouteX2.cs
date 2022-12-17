namespace nilnul.fs._address.route_.stem.op_.of_
{

	static public class _RouteX2
	{

		static public StemI1 _Fro(RouteI1 route)
		{
			switch (route)
			{
				case route_.StemI1 stem:
					return stem;
				case route_.SprigI1 sprig:
					return _SprigDeckX1.Of(sprig);
				default:

					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		static public StemI1 Fro(string route)
		{
			return _Fro(RouteA1.Parse(route));
		}

		static public StemI1 Fro(RouteI1 route)
		{
			switch (route)
			{
				case route_.StemI1 stem:
					return stem;
				default:
				return Fro(route.ToString());

					break;
			}
		}



	}
}
