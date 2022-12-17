using System;
using System.Linq;

namespace nilnul.fs._address.denotation_
{

	[Obsolete(nameof(_route.division_.denotation_.DivDenotation))]
	public class DivDenotation
		:
		//DivisionI,

		DocumentI
		
	{

		private DivI _base;

		public DivI @base
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

		public DivI div => nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(_base, _document.div);

		public DivDenotation(
			DivI @base,
			DocumentI document

		)
		{
			_base = @base;
			_document = document;
		}

		public DivDenotation(string @base, string doc)
			: this(Div.Parse(@base), document_.DenotesCappedDoc.Parse(doc))
		{

		}

		public DivDenotation(DivI div1, string documentAftDiv)
			: this(div1, document_.DenotesCappedDoc.Parse(documentAftDiv))
		{
		}

		public DivDenotation(DirI d, DocumentI descendent)
			:this(new Div(d), descendent)
		{
		}

		public override string ToString()
		{
			return $"{_base}{_document}";
		}

		static public DivDenotation Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);



			return new DivDenotation(

				Div.CreateFroDsts(split.Take(split.Length - 1))
				,
				nilnul.fs._address.Document.Parse(split.Last())
			);

		}




	}
}
