using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address.str
{
	static public class _PhraseX
	{
		static public nilnul.txt.accumulate_.Join Joiner = new txt.accumulate_.Join(System.IO.Path.PathSeparator);

		static public string Phrase(IEnumerable<string> addresses)
		{
			return Joiner.accumulate(addresses);
		}

		public static string Phrase(IEnumerable<nilnul.fs.address_.ShieldI> shields)
		{
			return Phrase(shields.Select(x => x.ToString()));
		}
	}
}
