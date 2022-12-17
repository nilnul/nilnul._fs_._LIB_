using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.deckedDocument_
{
	[Obsolete()]
	public class OfDocument
		: RouteI
	{
		private nilnul.fs._address.document_.DivDoc _document;

		public nilnul.fs._address.document_.DivDoc document
		{
			get { return _document; }
			set { _document = value; }
		}

		public override string ToString()
		{
			return $"{nilnul.fs._address.Deck.ToTxt()}{document}";
		}

		public DivisionI division
		{
			get
			{
				return _document;

				throw new NotImplementedException();
			}
		}

		public OfDocument(
			nilnul.fs._address.document_.DivDoc document
		)
		{
			_document = document;
		}

		public static OfDocument CreateFroDeckedDivAndDocument(DeckedDiv deckedDiv, document_.DivDoc doc)
		{

			return new OfDocument(
				 new document_.DivDoc(
					 nilnul.fs._address.div.combine_.Concat.Singleton.eval(
						 deckedDiv.div,
						 doc.div

				)
				 ,
				 doc.doc)
			);
		}

		public static implicit operator DeckedDiv_Doc(OfDocument ofDocument)
		{

			return new DeckedDiv_Doc(
				new DeckedDiv(
					ofDocument.document.div
				)
				,
				ofDocument.document.doc
			);
		}

		public static implicit operator OfDocument(DeckedDocument v)
		{

			return new OfDocument(v.document);
			//throw new NotImplementedException();
		}

		static public OfDocument Parse(string txt)
		{

			nilnul.obj.vow_.True.Vow(
				txt.StartsWith("\\") || txt.StartsWith("/")
			);


			return new OfDocument(
				nilnul.fs._address.document_.DivDoc.Parse(
					txt.Substring(1)
				)
			);

		}


	}
}
