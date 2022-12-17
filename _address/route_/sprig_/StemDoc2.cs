using nilnul.fs._address._route.division_._div._dir.dnt_;

namespace nilnul.fs._address.route_.sprig_
{
	public class StemDoc1 :
		SprigA1
	//,
	//SprigI1
	{

		private StemI1 _stem;

		public StemI1 stem
		{
			get => _stem;
			set => _stem = value;
		}
		private _route.division_._div._dir.DntI _doc;

		public _route.division_._div._dir.DntI doc
		{
			get => _doc;
			set => _doc = value;
		}


		public override nilnul.fs._address._route.division_.div.DntedI denotation => new nilnul.fs._address._route.division_.div.Dnted(_stem.div, _doc);// throw new NotImplementedException();

		public StemDoc1(StemI1 stem, _route.division_._div._dir.DntI doc)
		{
			_stem = stem
				;
			_doc = doc;
		}
		public StemDoc1(StemI1 stem, _route.division_._div._dir.Dnt doc)
			:
			this(stem, (_route.division_._div._dir.DntI)doc)
		{

		}

		public StemDoc1(nilnul.fs._address.route_.StemI1 div, string doc)
		   : this(
			   div
			   ,
			   new _route.division_._div._dir.Dnt(doc)
			)
		{
		}

		public StemDoc1(SprigI1 sprig)
		{
			_stem = new nilnul.fs._address.route_.Stem1(sprig.denotation.div);

			_doc = sprig.denotation.dnt;



		}


		public StemDoc1(nilnul.fs._address._route.division_.DivI div, _route.division_._div._dir.DntI doc)
		   : this(
				new Stem1(
				   div
			   )
			   ,
			   doc
				)
		{

		}
		public StemDoc1(nilnul.fs._address._route.division_.DivI div, _route.division_._div._dir.Dnt doc)
		   : this(

				   div

			   ,
			  (_route.division_._div._dir.DntI)doc
				)
		{

		}



		public StemDoc1(
			nilnul.fs._address._route.division_.DivI div, string doc
		)
		: this(
			div, new _route.division_._div._dir.Dnt(doc)
		)
		{
		}

		public StemDoc1(StemI1 stem, Exted doc1)
			:this(stem, (_route.division_._div._dir.DntI)doc1)
		{
		}

		public override string ToString()
		{
			return $"{_stem}{_doc}";
		}
	}
}