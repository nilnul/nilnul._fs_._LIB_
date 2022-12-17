using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path
{
	static public class _DocX
	{

		static public string Txt(string path) {
			var lastIndex = path.LastIndexOfAny(
				nilnul.fs._address._route._SeparatorX.Chars
			);

			return path.Substring(lastIndex+1);
		}
	}
}
