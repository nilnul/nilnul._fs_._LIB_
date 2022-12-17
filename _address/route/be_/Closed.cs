using System;

namespace nilnul.fs._address.route.be_
{
	/// <summary>
	/// end at separator
	/// </summary>
	public class Closed : BeI,BeI1
	{
		public bool be(RouteI obj)
		{
			return division.be_.Div.Singleton.be(obj.division);
			//throw new NotImplementedException();
		}

		public bool be(string route)
		{
			return route.EndsWith(nilnul.fs._address._route_._SeparatorX.AsTxt) || route.EndsWith(nilnul.fs._address._route_._SeparatorX.AltAsTxt);
		}

		public bool be(RouteI1 route)
		{
			return _route. division.be_.Div.Singleton.be(route.division);

		}

		static public Closed Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Closed>.Instance;
			}
		}

	}
}
