using System;

namespace nilnul.fs._address
{
	[Obsolete()]
	public class Separator
	{
		public static char AsChar = System.IO.Path.DirectorySeparatorChar;
		public static readonly string AsTxt = System.IO.Path.DirectorySeparatorChar.ToString();
	}
}
