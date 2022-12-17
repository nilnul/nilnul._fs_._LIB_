using System.Text.RegularExpressions;

namespace nilnul.fs._address.division._parse
{

	/// <summary>
	/// </summary>
	public class Check : nilnul.obj._parse.CheckI
	{

		public string check(string s)
		{
			if (Regex.IsMatch(s, @"[^\\\/]\z"))
			{

				return fs._address.document._parse.Check.Singleton.check(s);
			}
			return fs._address.div._parse.Check.Singleton.check(s);
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
