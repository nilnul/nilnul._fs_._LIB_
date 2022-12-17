using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.div;

namespace nilnul.fs._address.route_.sprig_
{
	[Obsolete()]
	public class StemDoc1 :
		SprigA
	//,
	//SprigI1
	{

		private StemI1 _stem;

		public StemI1 stem
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


		public override DocumentI2 document => new nilnul.fs._address.Document2(_stem.div, _doc);// throw new NotImplementedException();

		public StemDoc1(StemI1 stem, DocI doc)
		{
			_stem = stem
				;
			_doc = doc;
		}

		public StemDoc1(SprigI1 sprig)
		{
			_stem = new nilnul.fs._address.route_.Stem1(sprig.document.div);

			_doc = sprig.document.doc;



		}


		public StemDoc1(nilnul.fs._address.DivI1 div, DocI doc)
		   : this(
				new Stem1(
				   div
			   )
			   ,
			   doc
				)
		{

		}



		public StemDoc1(nilnul.fs._address.DivI1 div, string doc)
		   : this(
				div, nilnul.fs._address.DocA.Parse(doc)
				)
		{
		}

		public StemDoc1(nilnul.fs._address.route_.StemI1 div, string doc)
		   : this(
			   div
			   ,
			   DocA.Parse(doc)
			)
		{
		}

		public override string ToString()
		{
			return $"{_stem}{_doc}";
		}
	}
}