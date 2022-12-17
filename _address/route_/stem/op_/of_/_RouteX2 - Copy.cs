using System;

namespace nilnul.fs._address.route_.stem_
{

	[Obsolete()]
	static public class _RouteX2
	{

		static public StemI _Fro(RouteI route)
		{
			switch (route)
			{
				case route_.StemI stem:
					return stem;
				case route_.SprigI sprig:
					return _SprigDeckX1.Construct(sprig);
				default:

					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		static public StemI Fro(string route)
		{
			return _Fro(RouteA.Parse(route));
		}

		static public StemI Fro(RouteI route)
		{
			switch (route)
			{
				case route_.StemI stem:
					return stem;
				default:
				return Fro(route.ToString());

					break;
			}
		}



	}
}
