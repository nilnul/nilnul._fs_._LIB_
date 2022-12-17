using System;
using System.Linq;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	static public class _DocumentX
	{
		static public Div Exe(DocumentI document)
		{
			return new Div(
				document.div.dirs.Concat(
					new DirI[] {
						new Dir(
							document.doc
						)
					}
				)
			);
		}
		static public DivI Exe_byDivCo(DocumentI document)
		{
			return
				div.op_.binary_.Concat.Singleton.op(document.div, document.doc)
			;
		}


	}
}