using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_
{
	public interface IDivision:IContextual
	{
	}

	public interface DivisionI
		:IDivision
		,
		_division_.ToLiteralI
	{

	}

	static public  class DivisionIX
	{
		static public DivisionI Ov(IDivision division) {
			return division switch {
				DivisionI x=>x
				,
				_ => nilnul.fs.path_.division._ParseX.Parse(division.ToString())
			};
		}

		static public DivisionI ToShrink(this DivisionI division) {
			return division switch {
				path_.division_.Div div => div.toShrink()
				,
				path_.division_.div.StepAppended  denotation=>denotation.toShrink()
				,
				path_.division_._div._dir.Steps steps=>steps.toShrink()
				,
				 _ => ToShrink_assumeDiv0division(
					path_.division._ParseX.Parse(
						 division.ToString()
					)
				 )
			};
		}

		static public DivisionI ToShrink_assumeDiv0division(this DivisionI division) {

			return division switch {
				path_.division_.Div div => div.toShrink()
				,
				path_.division_.div.StepAppended  denotation=>denotation.toShrink()
				
			};

		}


	}
}
