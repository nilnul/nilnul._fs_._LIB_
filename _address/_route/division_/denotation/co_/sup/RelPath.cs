using nilnul.fs._address.divDivision;
using nilnul.fs.path_.division_.div;
using System;

namespace nilnul.fs._address._route.division_.denotation.co_.sup
{


	static public class _RelPathX
	{
		
		static public nilnul.fs._address._route.DivisionI RelPath(
			DenotationI src
			,
			DenotationI dst
		)
		{
			if (_address._route.division_.denotation.Eq.Singleton.Equals(src,dst))
			{
				return new _address._route.division_.Div();
			}


			return _route.division.co_.divDenotation_.sup.RelPathX.Denotation(

				new _address.Div(src)

				, dst

				);
		}

		

		public static nilnul.fs._address._route.DivisionI RelPath(DocumentI denotation, DocumentI document)
		{
			return RelPath(
				_address.denotation._OfDocumentX.Denotation(denotation)
				,
				_address.denotation._OfDocumentX.Denotation(document)
			);
		}
	}
}
