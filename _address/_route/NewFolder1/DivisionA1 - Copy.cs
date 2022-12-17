using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs._address
{

	/// <summary>
	/// </summary>
	///
	[Obsolete()]
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
				return Document.Parse(s);
			}
			return Div.Parse(s);
		}

		static public DivisionI Parse1(string s)
		{
			if (Regex.IsMatch(s, @"[^\\\/]\z"))
			{
				return Denotation.Parse(s);
			}
			return Div.Parse(s);
		}

		/// <summary>
		/// normalize to div or document
		/// </summary>
		/// <param name="division"></param>
		/// <returns></returns>
		static public DivisionI Normal(DivisionI division)
		{
			switch (division)
			{
				case DivI div:
					return div;
				case DocumentI document:
					return document;

				default:
					return Parse(division.ToString());
					break;
			}
		}

		static public DivisionI Normal1(DivisionI division)
		{
			switch (division)
			{
				case DivI div:
					return div;
				case DenotationI document:
					return document;

				default:
					return Parse(division.ToString());
					break;
			}
		}

		static public DivisionI Ov(IEnumerable<_address.DntI1> dnts) {
			if (dnts.Any())
			{
				//an denotation
				return Denotation._OvAssumeStarted(dnts);

			}
			return new Div();
		}




	}


}
