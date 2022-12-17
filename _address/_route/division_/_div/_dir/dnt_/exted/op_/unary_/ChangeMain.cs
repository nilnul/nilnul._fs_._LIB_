using nilnul.fs._address.doc_._exted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.denote_.exted.op_.unary_
{
	static public class _ChangeMainX
	{
		static public nilnul.fs._address.doc_.MainExt ChangeMain( nilnul.fs._address.doc_.MainExt denote
			,
			nilnul.fs._address.doc_._exted.Main newMain

			) {
			return new doc_.MainExt(newMain, denote.ext);
		}

		public  static nilnul.fs._address.doc_.MainExt ChangeMain(DocI doc, MainI newMain)
		{
			return ChangeMain(
				 doc_.MainExt.Ov(doc)
				,
				newMain
			);
		}
	}
}
