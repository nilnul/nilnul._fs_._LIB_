using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document_.divDoc._div
{
	static public class _TxtX
	{
		static public string Div(string document)
		{
			return document.Substring(
				0,

				document.LastIndexOfAny(
					nilnul.fs._address._route._SeparatorX.Chars
				)
			);
		}
	}
}
