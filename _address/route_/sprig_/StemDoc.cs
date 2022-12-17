using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.sprig_
{
	[Obsolete()]
	public class StemDoc:SprigI
	{

		private StemI _stem;

		public StemI stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DocI _doc;

		public DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public DivisionI division=> document;

		public DocumentI1 document =>new  nilnul.fs._address.Document1(_stem.div,_doc) ;// throw new NotImplementedException();

		public StemDoc(StemI stem, DocI doc)
		{
			_stem = stem
				;
			_doc = doc;
		}

		public StemDoc(SprigI sprig)
		{
			_stem = new nilnul.fs._address.route_.stem_.DeckDiv(sprig.document.div);

			_doc = sprig.document.doc;

			

		}

		//public StemDoc(document_.DivDoc document)
		//	:this( new DeckedDiv( document.div), document.doc)
		//{

		//}

		//static public StemDoc CreateFroDivDoc(nilnul.fs._address.document_.DivDoc document) {
		//	return new StemDoc(
		//		new DeckedDiv(
		//			document.div
		//		)
		//		,
		//		document.doc
		//	);

		//}

		static public StemDoc FroDivDoc(nilnul.fs._address.DivI div, DocI doc) {
			return new StemDoc(
				new Stem(
					div
				)
				,
				(doc)
			);
		}



		static public StemDoc FroDivDoc(nilnul.fs._address.DivI div, string doc) {
			return FroDivDoc(div, nilnul.fs._address.DocA.Parse(doc));
		}

		static public StemDoc FroStemDoc(nilnul.fs._address.route_.Stem div, string doc) {
			return new StemDoc(
				
					div
				
				,
				DocA.Parse(doc)
			);
		}

		static public StemDoc FroStemDoc(nilnul.fs._address.route_.StemI div, nilnul.fs._address.DocI doc) {
			return new StemDoc(
				
					div
				
				,
				(doc)
			);
		}


		static public StemDoc FroStemDoc(nilnul.fs._address.route_.StemI div, string doc) {
			return new StemDoc(
				
					div
				
				,
				DocA.Parse(doc)
			);
		}



		//static public StemDoc Parse(string txt)
		//{

		//	nilnul.obj.vow_.True.Vow(
		//		txt.StartsWith("\\") || txt.StartsWith("/")
		//	);


		//	return new StemDoc(
		//		nilnul.fs._address.document_.DivDoc.Parse(
		//			txt.Substring(1)
		//		)
		//	);

		//}

		public override string ToString()
		{
			return $"{_stem}{_doc}";
		}



	}
}
