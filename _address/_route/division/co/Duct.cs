using nilnul.fs._address.divDivision;
using nilnul.fs._address.division.co._duct._pass;
using System.Collections.Generic;

namespace nilnul.fs._address.division.co
{
	/// <summary>
	/// regarding document as a special directory which contains none; in other words, it's an empty container, the decoration of the container carries meaning, like the china ancient jar, which later becomes relic art ware, not utensil to containing living items any longer.
	/// 
	/// alias:
	///		duct
	///		Pass.
	/// </summary>

	static public class RelPathX
	{


		static public _address.division.co._duct.IPass RelPath(DivisionI src, DivisionI dst)
		{
			switch (src)
			{
				case DivI div:
					return division.co_.divDivision.RelPathX.RelPath(div, dst);
				case IDenotation denotation:
					return division.co_.denotationDivision.RelPathX.RelPath(denotation,dst);

				default:
					throw new UnexpectedTypeException();
					break;
			}
			
		}

		static public path_.contextual_.DivisionI Path_sinceContainerIfDenotation(DivisionI src, DivisionI dst)
		{
			switch (src)
			{
				case DivI div:
					return division.co_.divDivision.RelPathX.Division(div, dst);
				case IDenotation denotation:
					return division.co_.denotationDivision.RelPathX.Division_sinceSrcContainer(denotation,dst);

				default:
					throw new UnexpectedTypeException();
					break;
			}
			
		}

		static public path_.contextual_.DivisionI Path_srcMadeDivIfDenotation(DivisionI src, DivisionI dst)
		{
			switch (src)
			{
				case DivI div:
					return division.co_.divDivision.RelPathX.Division(div, dst);
				case IDenotation denotation:
					return division.co_.denotationDivision.RelPathX.Division_srcMadeDiv(denotation,dst);

				default:
					throw new UnexpectedTypeException();
					break;
			}
			
		}

		static public IEnumerable<IStep> Exe(DivisionI div, DivisionI div1)
		{
			var stub = _address.division.co._SharedPrefixX.Dnts(div, div1);

			var backs = nilnul.fs._address.dnts.co_.sup._DistanceX._Int_ofSupSub(stub, div);

			var forwards = nilnul.fs._address.dnts.co_.sup._DifX._Dnts_ofSupSub(stub, div1);

			return  division.co._duct._pass.Steps.OvUpsForwards(backs, forwards);

		}


	}
}
