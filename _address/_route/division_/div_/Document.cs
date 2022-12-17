using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	static public class _DocumentX
	{
		static public Div1 Exe(DocumentI2 document) {
			return new Div1(
				document.div.dirs.Concat(
					new DirI1[] {
						new Dir1(
							document.doc
						)
					}
				)
			);
		}
		static public DivI1 Exe_byDivCo(DocumentI2 document) {
			return 
				div.co_.Concat1.Singleton.op(document.div, document.doc)
			;
		}


	}
}