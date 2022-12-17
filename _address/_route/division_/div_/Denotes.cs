using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div_
{
	public static class _DenotesX
	{

		public static IEnumerable<string> Txts(string x)
		{
			return x.Split(
				nilnul.characters_.DirSeperator.Chars
			);
		}
		public static IEnumerable<_dst.Denote> Denotes(string x)
		{
			return Txts(x).Select(y => new _dst.Denote(y));
		}
	}
}
