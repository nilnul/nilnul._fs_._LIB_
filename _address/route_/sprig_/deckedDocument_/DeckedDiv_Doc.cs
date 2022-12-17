using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.deckedDocument_
{
	[Obsolete(nameof(route_.sprig_.StemDoc))]
	public class DeckedDiv_Doc:RouteI
	{

		private DeckedDiv _deckedDiv;

		public DeckedDiv deckedDiv
		{
			get { return _deckedDiv; }
			set { _deckedDiv = value; }
		}
		private DocNameI _doc;

		public DocNameI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public DivisionI division
		{
			get
			{
				return new document_.DivDoc(
					_deckedDiv.div
					,_doc
				);
				throw new NotImplementedException();
			}
		}

		public DeckedDiv_Doc(DeckedDiv deckedDiv, DocNameI doc)
		{
			_deckedDiv = deckedDiv
				;
			_doc = doc;
		}

		

		public DeckedDiv_Doc(document_.DivDoc document)
			:this( new DeckedDiv( document.div), document.doc)
		{

		}

		static public DeckedDiv_Doc CreateFroDivDoc(nilnul.fs._address.document_.DivDoc document) {
			return new DeckedDiv_Doc(
				new DeckedDiv(
					document.div
				)
				,
				document.doc
			);

		}

		static public DeckedDiv_Doc CreateFroDivDoc(nilnul.fs._address.DivI div, DocNameI doc) {
			return new DeckedDiv_Doc(
				new DeckedDiv(
					div
				)
				,
				(doc)
			);
		}



		static public DeckedDiv_Doc CreateFroDivDoc(nilnul.fs._address.DivI div, string doc) {
			return new DeckedDiv_Doc(
				new DeckedDiv(
					div
				)
				,
				DocNameA.Parse(doc)
			);
		}

		static public DeckedDiv_Doc CreateFroDeckedDivDoc(nilnul.fs._address.route_.DeckedDiv div, string doc) {
			return new DeckedDiv_Doc(
				
					div
				
				,
				DocNameA.Parse(doc)
			);
		}


		static public DeckedDiv_Doc Parse(string txt)
		{

			nilnul.obj.vow_.True.Vow(
				txt.StartsWith("\\") || txt.StartsWith("/")
			);


			return new DeckedDiv_Doc(
				nilnul.fs._address.document_.DivDoc.Parse(
					txt.Substring(1)
				)
			);

		}

		public override string ToString()
		{
			return $"{_deckedDiv}{_doc}";
		}



	}
}
