namespace nilnul.fs._address.route
{
	static public class _LocalNameX
	{
		static public string Name(RouteI r)
		{
#pragma warning disable CS0618 // '_LocalNameX.Name(DivisionI)' is obsolete: 'defending against old types'
			return division._LocalNameX.Name(r.division);// r.division;
#pragma warning restore CS0618 // '_LocalNameX.Name(DivisionI)' is obsolete: 'defending against old types'
		}
	}
}
