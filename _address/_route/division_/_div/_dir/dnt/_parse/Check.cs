using System;

namespace nilnul.fs._address._dst.denote._parse
{
	public class Check : nilnul.obj._parse.CheckI
	{
		public string check(string obj)
		{
			try
			{
				scan_._WordX.Parse(obj);
			}
			catch (Exception e)
			{
				return e.ToString() + " ";

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
