using System;
using System.Linq;

namespace nilnul.fs._address._route.division_.denotation_
{

	public class DivDenotation
		:
		//DivisionI,

		div.DntedI
		
	{

		private DivI _base;

		public DivI @base
		{
			get { return _base; }
			set { _base = value; }
		}
		private div.DntedI _document;

		public div.DntedI document
		{
			get { return _document; }
			set { _document = value; }
		}

		public _address._route.division_._div._dir. DntI dnt => _document.dnt;

		public DivI div =>  nilnul.fs._address._route.division_.div.op_.binary_
.Concat.Singleton.op(_base, _document.div);

		public DivDenotation(
			DivI @base,
			div.DntedI document

		)
		{
			_base = @base;
			_document = document;
		}

		public DivDenotation(string @base, string doc)
			: this(Div.Parse(@base), _route.division_. div.Dnted.Parse(doc))
		{

		}

		public DivDenotation(DivI div1, string documentAftDiv)
			: this(div1, _route.division_.div.Dnted.Parse(documentAftDiv))
		{
		}

		public DivDenotation(_route.division_._div. DirI d, _route.division_.div.DntedI descendent)
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

				Div.OfDsts(split.Take(split.Length - 1))
				,
				nilnul.fs._address._route.division_.div.Dnted.Parse(split.Last())
			);

		}




	}
}
