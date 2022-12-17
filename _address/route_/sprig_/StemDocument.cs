using nilnul.fs._address._route.division_.div;

namespace nilnul.fs._address.route_.sprig_
{
	public class StemDenotation :
		SprigA1

	{

		private StemI1 _stem;

		public StemI1 stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private DntedI  _documentAftStem;

		public override DntedI denotation => new nilnul.fs._address._route.division_.denotation_.DivDenotation(_stem.div, _documentAftStem);// throw new NotImplementedException();

		public StemDenotation(StemI1 stem, DntedI documentAftStem)
		{
			_stem = stem
				;
			_documentAftStem = documentAftStem;
		}

		public StemDenotation(SprigI1 sprig)
		{
			_stem = new nilnul.fs._address.route_.Stem1(sprig.denotation.div);

			_documentAftStem = new nilnul.fs._address._route.division_.div.Dnted(sprig.denotation.dnt);
		}

		public StemDenotation(
			nilnul.fs._address._route.division_.DivI div
			,
			nilnul.fs._address._route.division_.div.DntedI documentAftDiv
		)
		   : this(
				new Stem1(
				   div
			   )
			   ,
			   documentAftDiv
			)
		{

		}


		public StemDenotation(nilnul.fs._address._route.division_.div.DntedI document) : this(new Sprig1(document))
		{


		}


		public StemDenotation(nilnul.fs._address._route.division_.DivI div, string documentAftDiv)
		   : this(
				 new nilnul.fs._address._route.division_.denotation_.DivDenotation(div, documentAftDiv)
				 )

		{
		}

		public StemDenotation(nilnul.fs._address.route_.StemI1 div, string document)
		   : this(
			   div
			   ,
			   Dnted.Parse(document)
			)
		{
		}

		public override string ToString()
		{
			return $"{_stem}{_documentAftStem}";
		}
	}
}