using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc_
{
	[Obsolete()]
	public interface DottedOrNoI:DocI1 {

	}

	[Obsolete()]
	static public class DottedOrNoIX
	{
		static public DottedOrNoI Parse(string s)
		{

			var lastDot = s.LastIndexOf(DocA1.DOT);

			if (lastDot < 0)
			{
				return doc_.NoDot1.Parse(s);
				//throw new ArgumentException();
			}
			else
			{

				return doc_.Dotted1.Parse(
					s.Substring(0, lastDot)
					,
					s.Substring(lastDot + 1)  ///per doc, 如果 startIndex 等于此实例的长度，则为 Empty。

				);
			}
		}

		static public DottedOrNoI Fro(nilnul.fs._address.DocI1 s)
		{
			return Parse(s.name);
		}
		static public DottedOrNoI Fro(nilnul.fs._address.DocI2 s)
		{
			return Parse(s.denote);
		}



	}
}
