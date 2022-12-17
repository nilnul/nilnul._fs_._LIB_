namespace nilnul.fs._address.route_.sprig_
{

	static public class _RouteX2
	{

		static public SprigI _Fro(RouteI route)
		{
			switch (route)
			{
				case route_.StemI stem:

					return sprig_._StemX.Construct(stem);

				case route_.SprigI sprig:
					return sprig;
				default:

					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		static public SprigI Fro(string route)
		{
			return _Fro(RouteA.Parse(route));
		}

		static public SprigI Fro(RouteI route)
		{
			return Fro(route.ToString());
		}


	}
}
