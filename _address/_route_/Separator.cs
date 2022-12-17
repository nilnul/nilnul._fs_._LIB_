namespace nilnul.fs._address._route_
{
	static public class _SeparatorX
	{
		public static char AsChar = System.IO.Path.DirectorySeparatorChar;
		public static readonly string AsTxt = System.IO.Path.DirectorySeparatorChar.ToString();

		public static readonly string AltAsTxt = System.IO.Path.AltDirectorySeparatorChar.ToString();

		public static char[] Chars = new char[] { AsChar, System.IO.Path.AltDirectorySeparatorChar };
	}
}
