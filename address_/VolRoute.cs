using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete()]

	public class VolRoute
		:VolRouteI
	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs._address.RouteI _route;

		public nilnul.fs._address.RouteI route
		{
			get { return _route; }
			set { _route = value; }
		}

		public VolRoute(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.RouteI route
			
		)
		{
			_vol = vol;
			_route = route;


		}

		

		public override string ToString()
		{
			return $"{_vol}{_route}";
		}

		static public VolRoute Parse(string s) {
			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, 2));


			var route = _address.Route.Parse(s.Substring(2));

			return new VolRoute(vol, route);
		}

		


	}
}
