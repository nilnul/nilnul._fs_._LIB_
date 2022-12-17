using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.division.co_
{
	static public class _DivDivisionX
	{
		
		[Obsolete("use callee direct")]
		static public path_.division_.Div Division(path_.division_.Div div, path_.division_.Div div1) {

			return division_.div.CoX.Band(div, div1);
		}

		static public path_.contextual_.DivisionI Division(path_.division_.Div div, path_.contextual_.DivisionI division) {

			switch (division)
			{
				case path_.division_.Div div1:
					return path_.division_.div.CoX.Band(div, div1);
				case path_.division_.div.StepAppended denotation:

					return _DivDenotationX.Denotation(
						div, denotation
					);
				default:
					throw new UnexpectedTypeException(
						$"{division} shall be either Div or Denotation"
					);
					break;
			}
		}

		public static contextual_.IDivision Division(DivI div, contextual_.DivisionI route)
		{
			return Division(
				new division_.Div(div),route
			);
		}
	}
}
