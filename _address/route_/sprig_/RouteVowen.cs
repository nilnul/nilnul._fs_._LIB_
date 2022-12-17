namespace nilnul.fs._address.route_.sprig_
{

	public class RouteVowen
		:
		route.be_.open.vow.En
		,
		SprigI
	{
		public RouteVowen(RouteI val) : base(val)
		{
		}

		public DivisionI division => document;// throw new NotImplementedException();
		public DocumentI document => _address.DocumentIX.Downcast(en.division);

		public static RouteVowen Parse(string route)
		{
			return new RouteVowen(_address.RouteA.Parse(route));
		}


	}


}