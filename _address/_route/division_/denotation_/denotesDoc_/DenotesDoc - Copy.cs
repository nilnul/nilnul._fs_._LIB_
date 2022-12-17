using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.document_
{

	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(denotation_.divDoc_.DenotesDoc))]
	public class DenotesCappedDoc
		:


		DocumentI
	{
		private nilnul.fs._address._dst.denote.str_.seq.Join _denotes;
		public nilnul.fs._address._dst.denote.str_.seq.Join denotes
		{
			get { return _denotes; }
			set { _denotes = value; }
		}
		private DocI _doc;
		public DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public DivI div => _denotes.toDiv();

		public DenotesCappedDoc(
			nilnul.fs._address._dst.denote.str_.seq.Join div,
			DocI doc
		)
		{
			_denotes = div;
			_doc = doc;
		}

		public DenotesCappedDoc(
			DocI doc
			) : this(
				new nilnul.fs._address._dst.denote.str_.seq.Join()
				, doc
			)
		{
		}

		public DenotesCappedDoc(string dsts, string doc)
			: this(nilnul.fs._address._dst.denote.str_.seq.Join.Parse2Str(dsts), new Doc(doc))
		{
		}

		public DenotesCappedDoc(IEnumerable<Denote> enumerable, DocI doc) : this(new _dst.denote.str_.seq.Join(enumerable), doc)
		{

		}



		public Document toDocument()
		{
			return new Document(
				this.denotes.toDiv()
				, this.doc
			);
		}


		public override string ToString()
		{
			return toDocument().ToString();
		}

		static public DenotesCappedDoc Parse(string txt)
		{
			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);
			return new DenotesCappedDoc(

				new _dst.denote.str_.seq.Join(split.Take(split.Length - 1))
				,
				new nilnul.fs._address.Doc(split.Last())
			);
		}
	}
}