namespace nilnul.fs.address._parse
{
	class _CheckX
	{
	}
	public class Check : nilnul.obj._parse.CheckI
	{
		public string check(string s)
		{
			if (s == "")
			{
				return "必填";
			}
			if (s.Length < 2)
			{
				return ($@"{s} is too short for an address.");
			}

			var volCheck = nilnul.fs._address.vol._parse.Check.Singleton.check(s.Substring(0, 2));

			if (volCheck != "")
			{
				return "the starting two letters are not Vol";
			}



			var route = _address.route._parse.Check.Singleton.check(s.Substring(2));

			if (route != "")
			{
				return $"route(after \":\") checked fail:{route}";
			}
			return "";

		}

		static public Check Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Check>.Instance;
			}
		}

	}
}
