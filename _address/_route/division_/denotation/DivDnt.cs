using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.denotation_
{
	static public class _DivDntX
	{
		static public ( string,string) DivDnt(string document)
		{
			var sep = document.LastIndexOfAny(
					nilnul.fs._address._route._SeparatorX.Chars
				);
			return ( document.Substring(
					0,

					sep
				)
				,
				document.Substring( sep)
			);
		}
	}
}
