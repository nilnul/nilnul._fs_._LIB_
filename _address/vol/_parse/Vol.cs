namespace nilnul.fs._address.vol._parse
{
	public class Check :
		nilnul.obj._parse.CheckI
	{

		public string check(string s)
		{
			if (!s.EndsWith(":"))
			{
				return "vol is not ended with ':'";
			}
			if (s.Length != 2)
			{
				return "vol length is not 2.";
			}
			if (!char.IsLetter(s[0]))
			{
				return "the first letter is not letter";
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
