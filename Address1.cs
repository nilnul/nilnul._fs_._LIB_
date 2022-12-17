using System;

namespace nilnul.fs
{
	[Obsolete("this shall be abstract")]
	public class Address
		:
		AddressI
		,
		_address_.VolI
		,
		_address_.RouteI
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

		public Address(
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

		static public Address Parse(string s)
		{

			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, 2));


			var route = _address.RouteA.Parse(s.Substring(2));

			return new Address(vol, route);
		}




	}
}
