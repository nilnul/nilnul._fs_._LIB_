using nilnul.fs._address.doc_._exted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dnt_.exted_.dotted
{
	/// <summary>
	/// given an ext that is not empty (in other words, dot led), ensure the dnt is with that ext.
	/// </summary>
	static public class _EnsureExtX
	{
		static public nilnul.fs._address.doc_.MainExt _MainExt_assumeExtNe(
			nilnul.fs._address.doc_.MainExt denote
			,
			nilnul.fs._address.doc_._exted.ext_.OvAftDot givenExt
		) {
			
				///remove trailing dots, cuz:
				///		1) if one dot in tail: append the givenExt would result two dots in returned name
				///		2) if morethan one dot in tail, resulted name would have consecutive two dots
				return   doc_.MainExt.Parse(denote.ToString().TrimEnd('.')+ givenExt.ToString());
		}

		
		public  static nilnul.fs._address.doc_.MainExt _MainExt_assumeExtNe(DocI doc, doc_._exted.ExtI extI)
		{

			return _MainExt_assumeExtNe(
				 doc_.MainExt.Ov(doc)
								,
				 doc_._exted.ext_.OvAftDot.ParseOfLed(extI.ToString())
			);

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
				return _MainExt_assumeExtNe(denote,givenExt);
			}
			return denote;
		}

		public  static nilnul.fs._address.doc_.MainExt MainExt(
			DocI doc
			,
			nilnul.fs._address.doc_._exted.ext_.OvAftDot givenExt
		)
		{
			return MainExt(
				 doc_.MainExt.Ov(doc)
				,
				givenExt
			);
		}


		public  static string _Txt_ofMain0doc_ofExtWithLeadingDotOptional(string main0doc, string ext)
		{
			var e = _address.doc_._exted.ext_.OvAftDot.PrependDotIfNeed(ext);
			var extAsTxt = e.ToString();
			if (main0doc.EndsWith(extAsTxt))
			{
				return main0doc;
			}
			return main0doc + extAsTxt;
		}

		public  static doc_.exted_.Dotted _Doc_ofMain0doc_ofExtWithLeadingDotOptional(string main0doc, string ext)
		{
			return  doc_.exted_.Dotted.Parse(
				_Txt_ofMain0doc_ofExtWithLeadingDotOptional(main0doc,ext)

			);
		}



	}
}
