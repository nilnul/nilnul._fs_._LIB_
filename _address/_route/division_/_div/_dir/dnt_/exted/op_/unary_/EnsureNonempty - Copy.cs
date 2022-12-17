using nilnul.fs._address.doc_._exted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc_.exted.op_.unary_
{

	[Obsolete()]
	static public class _EnsureGivenNonemptyX
	{
		static public nilnul.fs._address.doc_.MainExt _MainExt_assumeNe(
			nilnul.fs._address.doc_.MainExt denote
			,
			nilnul.fs._address.doc_._exted.ext_.OvAftDot givenExt
		) {
			
				///remove trailing dots, cuz:
				///		1) if one dot in tail: append the givenExt would result two dots in returned name
				///		2) if morethan one dot in tail, resulted name would have consecutive two dots
				return   doc_.MainExt.Parse(denote.ToString().TrimEnd('.')+ givenExt.ToString());
			

			
		}
		static public nilnul.fs._address.doc_.MainExt MainExt(
			nilnul.fs._address.doc_.MainExt denote
			,
			nilnul.fs._address.doc_._exted.ext_.OvAftDot givenExt
		) {
			if (
				nilnul.fs._address.doc_._exted.ext.eq.Ne.Singleton.ne( denote.ext, givenExt   )
			)
			{
				return _MainExt_assumeNe(denote,givenExt);
			}
			return denote;

			
		}

		public  static nilnul.fs._address.doc_.MainExt MainExt(DocI doc,
			nilnul.fs._address.doc_._exted.ext_.OvAftDot givenExt )
		{
			return MainExt(
				 doc_.MainExt.Ov(doc)
				,
				givenExt
			);
		}

		public  static DocI _MainExt_assumeNe(DocI doc, _exted.ExtI extI)
		{
			return _MainExt_assumeNe(
				 doc_.MainExt.Ov(doc)
								,
				 _exted.ext_.OvAftDot.ParseOfLed(extI.ToString())
			);

		}
	}
}
