using System;
using System.Text.RegularExpressions;

namespace nilnul.fs._address._route.division_
{

	/// <summary>
	/// </summary>
	///
	public abstract class DestinationA
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public DestinationI Parse(string s)
		{
			if (Regex.IsMatch(s, @"[^\\\/]\z"))
			{
				return division_.div.Dnted.Parse(s);
			}
			return division_.div_.Directory.Parse(s);
		}

		static public DestinationI Denotation0directory(DestinationI s)
		{
			switch (s)
			{
				case division_.div.DntedI document:
					return document;
				case division_.div_. DirectoryI directory:
					return directory;
				default:
					return Parse(s.ToString());
					break;
			}
		}






	}


}
