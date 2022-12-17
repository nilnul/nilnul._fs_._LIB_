namespace nilnul.fs._address._route
{
	/// <summary>
	/// either "/", or "\"
	/// </summary>
	/// <remarks>
	/// alias:
	///		Deck
	/// </remarks>
	static public class _SeparatorX
	{

		public static char AsChar = System.IO.Path.DirectorySeparatorChar;
		public static readonly string AsTxt = System.IO.Path.DirectorySeparatorChar.ToString();

		public static readonly string AltAsTxt = System.IO.Path.AltDirectorySeparatorChar.ToString();

		public static char[] Chars = new char[] { AsChar, System.IO.Path.AltDirectorySeparatorChar };
		public static char Default = System.IO.Path.DirectorySeparatorChar;
	}
}
