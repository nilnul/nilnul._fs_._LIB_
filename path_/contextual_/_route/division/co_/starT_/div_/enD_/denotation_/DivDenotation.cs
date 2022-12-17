using nilnul.fs._address;
using nilnul.fs.path_.contextual_._route.division_.denotation_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_._route.division.co_.starT_.div_.enD_.denotation_
{
	static public class _EndDntX
	{
		static public division_.denotation_.DntAppended DntEnd(
			path_.division_.Div div
			,
			path_.contextual_._route.division_.denotation_.DntAppended division
		) {
			return new division_.denotation_.DntAppended(

				path_.division_.div.CoX.Band(div, division.container)
				,
				division.dnt
			); 

		}

		

		public static DntAppended DntEnd(DivI div, DntAppended route)
		{
			return DntEnd(
				new path_.division_.Div(div),route
			);

		}
	}
}
