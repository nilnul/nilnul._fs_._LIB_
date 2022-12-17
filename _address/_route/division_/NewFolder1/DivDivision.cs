using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division_
{
	static public class _DivDivisionX
	{
		static public nilnul.fs._address.DivisionI Concat(_address.DivI div, _address.DivisionI division) {

			switch (_address.DivisionA.Normal(division))
			{
				case DivI div1:
					return _address.div.op_.binary_.Concat.Singleton.op(div, div1);
				case DocumentI document:
					return denotation_._DivDenotationX.Splice(div, document);
				default:
					throw new UnexpectedTypeException();
					break;
			}
			//return _address.divDivision._ConcatX.Concat(div, division);
		}


	}
}
