using System;

namespace nilnul.fs._address.route_.sprig_
{
	[Obsolete()]
	public class StemDocument :
		SprigA

	{

		private StemI _stem;

		public StemI stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DocumentI _documentAftStem;

		public override DocumentI document => new nilnul.fs._address.document_.BaseDocument(_stem.div, _documentAftStem);// throw new NotImplementedException();

		public StemDocument(StemI stem, DocumentI documentAftStem)
		{
			_stem = stem
				;
			_documentAftStem = documentAftStem;
		}

		public StemDocument(SprigI sprig)
		{
			_stem = new nilnul.fs._address.route_.Stem(sprig.document.div);

			_documentAftStem = new nilnul.fs._address.Document(sprig.document.doc);
		}

		public StemDocument(nilnul.fs._address.DivI div, DocumentI documentAftDiv)
		   : this(
				new Stem(
				   div
			   )
			   ,
			   documentAftDiv
			)
		{

		}


		public StemDocument(DocumentI document) : this(new Sprig(document))
		{


		}


		public StemDocument(nilnul.fs._address.DivI div, string documentAftDiv)
		   : this(
				 new _address.document_.BaseDocument(div, documentAftDiv)
				 )

		{
		}

		public StemDocument(nilnul.fs._address.route_.StemI div, string document)
		   : this(
			   div
			   ,
			   Document.Parse(document)
			)
		{
		}

		public override string ToString()
		{
			return $"{_stem}{_documentAftStem}";
		}
	}
}