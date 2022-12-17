using System;
using System.Text.RegularExpressions;

namespace nilnul.fs._address
{

	/// <summary>
	/// </summary>
	///
	[Obsolete()]
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
				return Document.Parse(s);
			}
			return Directory.Parse(s);
		}

		static public DestinationI Document0Directory(DestinationI s)
		{
			switch (s)
			{
				case DocumentI document:
					return document;
				case DirectoryI directory:
					return directory;
				default:
					return Parse(s.ToString());
					break;
			}
		}






	}


}
