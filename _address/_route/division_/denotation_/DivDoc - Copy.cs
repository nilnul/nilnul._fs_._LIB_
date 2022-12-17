using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document_
{
	[Obsolete(nameof(denotation_._DivDntX))]
	static public class _DivDocX
	{
		static public ( string,string) DivDoc(string document)
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
