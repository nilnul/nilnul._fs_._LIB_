using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem_
{
	[Obsolete()]
	static public class _RouteX1
	{

		static public StemI1 _Fro(RouteI route) {
			switch (route)
			{
				case route_.StemI1 stem:
					return stem;
				case route_.SprigI1 sprig:
					return _SprigDeckX.Construct(sprig);
				default:
					throw new UnexpectedTypeException();
					break;
			}
			
		}

		static public StemI1 Fro(string route) {
			return _Fro(RouteA.Parse(route) );
		}

		static public StemI1 Fro(RouteI route) {
			return Fro(route.ToString());
		}


	}
}
