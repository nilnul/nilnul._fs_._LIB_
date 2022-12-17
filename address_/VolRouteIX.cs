using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete()]

	static public class VolRouteIX
	{
		

		static public VolRouteI Parse(string s) {
			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, 2));


			var route = _address.RouteIX.Parse(s.Substring(2));

			if (route is _address.route_.DeckedDiv)
			{
				return new volRoute_.Container(vol, route as _address.route_.DeckedDiv);
			}
			if (route is _address.route_.deckedDocument_.DeckedDiv_Doc)
			{
				return new volRoute_.Element(vol, route as _address.route_.deckedDocument_.DeckedDiv_Doc);
			}

			throw new UnexpectedTypeException();

			
		}

		static public volRoute_.ContainerI ToContainer(VolRouteI volRoute) {
			if (volRoute is volRoute_.ContainerI)
			{
				return volRoute as volRoute_.ContainerI;
			}

			return new volRoute_.Container(
				((volRoute_.ElementI)volRoute).vol
				,
				nilnul.fs._address.RouteIX.ToDiv(volRoute.route)
			);
		}


	}
}
