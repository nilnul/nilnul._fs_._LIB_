using System.Collections.Generic;
using System.Linq;

namespace nilnul.txts_.fs_
{
	static public class _AppendDecksX
	{


		public static IEnumerable<string> Seq(string s)
		{
			return nilnul.fs._address._route._SeparatorX.Chars.Select(x => s + x);
		}
		public static string[] Arr(string s)
		{
			return Seq(s).ToArray();
		}


	}
}
