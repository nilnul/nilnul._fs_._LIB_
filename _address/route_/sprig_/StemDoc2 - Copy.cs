using nilnul.fs._address._route.division_._div._dir.dnt_;
using System;

namespace nilnul.fs._address.route_.sprig_
{
	[Obsolete()]
	public class StemDoc :
		SprigA
	//,
	//SprigI1
	{

		private StemI _stem;

		public StemI stem
		{
			get => _stem;
			set => _stem = value;
		}
		private DocI _doc;

		public DocI doc
		{
			get => _doc;
			set => _doc = value;
		}


		public override DocumentI document => new nilnul.fs._address.Document(_stem.div, _doc);// throw new NotImplementedException();

		public StemDoc(StemI stem, DocI doc)
		{
			_stem = stem
				;
			_doc = doc;
		}
		public StemDoc(StemI stem, Doc doc) : this(stem, (DocI)doc)
		{

		}

		public StemDoc(nilnul.fs._address.route_.StemI div, string doc)
		   : this(
			   div
			   ,
			   new _address.Doc(doc)
			)
		{
		}

		public StemDoc(SprigI sprig)
		{
			_stem = new nilnul.fs._address.route_.Stem(sprig.document.div);

			_doc = sprig.document.doc;



		}


		public StemDoc(nilnul.fs._address.DivI div, DocI doc)
		   : this(
				new Stem(
				   div
			   )
			   ,
			   doc
				)
		{

		}
		public StemDoc(nilnul.fs._address.DivI div, Doc doc)
		   : this(

				   div

			   ,
			  (DocI)doc
				)
		{

		}



		public StemDoc(nilnul.fs._address.DivI div, string doc)
		   : this(
				div, new nilnul.fs._address.Doc(doc)
				)
		{
		}

		public StemDoc(StemI stem, Exted doc1)
		{
			this.stem = stem;
			this.doc = new _address.Doc(doc1.ToString());
		}

		public override string ToString()
		{
			return $"{_stem}{_doc}";
		}
	}
}