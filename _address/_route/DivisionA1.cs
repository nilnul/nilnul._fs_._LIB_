using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs._address._route
{

	/// <summary>

	/// </summary>
	public abstract class DivisionA
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		/// 



		static public DivisionI Parse(string s)
		{
			if (Regex.IsMatch(s, @"[^\\\/]\z"))
			{
				return division_.div.Dnted.Parse(s);
			}
			return division_.Div.Parse(s);
		}

		

	
		static public DivisionI Normal(DivisionI division)
		{
			switch (division)
			{
				case division_.DivI div:
					return div;
				case division_.div.DntedI document:
					return document;

				default:
					return Parse(division.ToString());
					break;
			}
		}

		static public DivisionI Ov(IEnumerable<_address._route.division_._div._dir.DntI> dnts) {
			if (dnts.Any())
			{
				//an denotation
				return division_.div.Dnted._OvAssumeStarted(dnts);

			}
			return new division_.Div();
		}




	}


}
