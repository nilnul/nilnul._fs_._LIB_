namespace nilnul.fs._address._route.sep._parse
{
	public class Check : nilnul.obj._parse.CheckI
	{
		public string check(char s)
		{
			if (s == System.IO.Path.DirectorySeparatorChar || s == System.IO.Path.AltDirectorySeparatorChar) return "";
			else
			{
				return "must be either / or \\";
			}
		}

		public string check(string obj)
		{
			if (obj.Length == 1)
			{
				return check(obj[0]);
			}
			else
			{
				return "should be one char long";
			}
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
