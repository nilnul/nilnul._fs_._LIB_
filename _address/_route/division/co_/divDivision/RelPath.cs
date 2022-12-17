using nilnul.fs._address.divDivision;
using System;

namespace nilnul.fs._address.division.co_.divDivision
{
	

	static public class RelPathX
	{
		static public co._duct.IPass RelPath(DivI src, DivisionI dst)
		{
			switch (dst)
			{
				case nilnul.fs._address.IDenotation denotation:
					return divDenotation.DuctX.Denotation(src,denotation);
				case nilnul.fs._address.DivI div:
					return nilnul.fs._address.div.co._RelPathX.Exe(src,div);

				default:
					throw new UnexpectedTypeException();
					break;
			}

		}

		static public path_.contextual_.DivisionI Division(DivI src, DivisionI dst)
		{
			switch (dst)
			{
				case nilnul.fs._address.IDenotation denotation:
					return divDenotation.DuctX.Denotation1(src,denotation);
				case nilnul.fs._address.DivI div:
					return nilnul.fs._address.div.co._RelPathX.Div(src,div);

				default:
					throw new UnexpectedTypeException();
					break;
			}

		}


		

	}
}
