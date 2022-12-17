using nilnul.fs._address.divDivision;
using System;

namespace nilnul.fs._address._route.division.co_.divDenotation_.sup
{

	static public class RelPathX
	{
		static public _address.Document Document(
			DivI sup
			,
			DenotationI denotationSub
		)
		{
			return
				new _address.Document(
					_address._route.division_.div.co_.sup._DifX2._ofSupSub(sup, denotationSub.div)
					,
					denotationSub.dnt
				);
		}

		static public _address._route.division_.div.Dnted Denotation(
			DivI sup
			,
			DenotationI denotationSub
		)
		{
			return
				 division_.div.dnted._RegressionsX.ToNew(
					Document(
						sup,denotationSub
					)
				);
		}
		static public _address.Document Document(
			DivI sup
			,
			DocumentI denotationSub
		)
		{
			return
				new _address.Document(
					_address._route.division_.div.co_.sup._DifX2._ofSupSub(sup, denotationSub.div)
					,
					denotationSub.doc
				);
		}

	}
}
