using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.document_
{

	public class DenotesDocument
		:
		//DivisionI,

		DocumentI
	{

		private nilnul.fs._address._dst.denote.str_.seq.Join _base;

		public nilnul.fs._address._dst.denote.str_.seq.Join @base
		{
			get { return _base; }
			set { _base = value; }
		}
		private DocumentI _document;

		public DocumentI document
		{
			get { return _document; }
			set { _document = value; }
		}

		public DocI doc => _document.doc;

		public DivI div => nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(_base.toDiv(), _document.div);

		public DenotesDocument(
			nilnul.fs._address._dst.denote.str_.seq.Join @base,
			DocumentI document

		)
		{
			_base = @base;
			_document = document;
		}

		public DenotesDocument(
			IEnumerable<
				nilnul.fs._address._dst.Denote
			> @base,
			DocumentI document
		) : this(
			new _dst.denote.str_.seq.Join(@base)
			, document
		)
		{
		}

		public DenotesDocument(string @base, string doc)
			: this(nilnul.fs._address._dst.denote.str_.seq.Join.Parse2Str(@base), DenotesCappedDoc.Parse(doc))
		{

		}

		public DenotesDocument(nilnul.fs._address._dst.denote.str_.seq.Join div1, string documentAftDiv)
			: this(div1, DenotesCappedDoc.Parse(documentAftDiv))
		{
		}

		public BaseDocument toDivDocument()
		{
			return new BaseDocument(
				this.@base.toDiv()
				,
				this.document
			);
		}

		public override string ToString()
		{
			return toDivDocument().ToString();
		}

		static public DenotesDocument Parse(string txt)
		{
			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);

			return new DenotesDocument(
				new _dst.denote.str_.seq.Join(

					split.Take(split.Length - 1)
				)
				,
				nilnul.fs._address.Document.Parse(split.Last())
			);

		}




	}
}
