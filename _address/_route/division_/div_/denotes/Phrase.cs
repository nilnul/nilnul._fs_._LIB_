using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div_.denotes
{
	static public class _PhraseX
	{
		static public string ToTxt(IEnumerable<_dst.Denote> denotes)
		{
#pragma warning disable CS0612 // 'Path' is obsolete
			return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(denotes.Select(x => x.ToString()));
#pragma warning restore CS0612 // 'Path' is obsolete
		}
	}
}
