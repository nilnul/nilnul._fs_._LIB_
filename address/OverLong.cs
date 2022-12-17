namespace nilnul.fs.address_
{
	/*To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. */
	/// <summary>
	/// 
	/// </summary>
	public class OverLong
	{
		public const string PREFIX = @"\\?\";
		static public bool IsOverLong(string s)
		{
			return s.StartsWith(PREFIX);
		}

		static public string Prepend(string s)
		{
			return $"{PREFIX}{s}";
		}

		static public string Ensure(string s)
		{
			return IsOverLong(s) ? s : Prepend(s);
		}




	}
}
