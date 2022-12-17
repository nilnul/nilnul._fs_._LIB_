using nilnul.fs._address.doc_._exted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnt_.exted.op_.unary_
{

	static public class _EnsureGivenNonemptyX
	{
		static public nilnul.fs._address._route.division_._div._dir.dnt_.Exted _MainExt_assumeNe(
			nilnul.fs._address._route.division_._div._dir.dnt_.Exted denote
			,
			nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_.OvAftDot givenExt
		) {
			
				///remove trailing dots, cuz:
				///		1) if one dot in tail: append the givenExt would result two dots in returned name
				///		2) if morethan one dot in tail, resulted name would have consecutive two dots
				return nilnul.fs._address._route.division_._div._dir.dnt_.Exted.Parse(
					denote.ToString().TrimEnd('.')+ givenExt.ToString()
				);
			

			
		}
		static public nilnul.fs._address._route.division_._div._dir.dnt_.Exted MainExt(
			nilnul.fs._address._route.division_._div._dir.dnt_.Exted denote
			,
			nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_.OvAftDot givenExt
		) {
			if (
				nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.eq.Ne.Singleton.ne( denote.ext, givenExt   )
			)
			{
				return _MainExt_assumeNe(denote,givenExt);
			}
			return denote;

			
		}

		public  static nilnul.fs._address._route.division_._div._dir.dnt_.Exted MainExt(
			nilnul.fs._address._route.division_._div._dir.DntI  doc
			,
			nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_.OvAftDot givenExt
		)
		{
			return MainExt(
				 dnt_.Exted.Ov(doc)
				,
				givenExt
			);
		}

		public  static nilnul.fs._address._route.division_._div._dir.dnt_.Exted _MainExt_assumeNe(nilnul.fs._address._route.division_._div._dir.DntI doc, _exted.ExtI extI)
		{
			return _MainExt_assumeNe(
				 nilnul.fs._address._route.division_._div._dir.dnt_.Exted.Ov(doc)
								,
				 _exted.ext_.OvAftDot.ParseOfLed(extI.ToString())
			);

		}
	}
}
