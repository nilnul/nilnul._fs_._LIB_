using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
		static public DivisionI Parse(string s) {
			if (Regex.IsMatch(s,  @"[^\\\/]\z") )
			{
				return Document2.Parse(s);
			}
			return Div1.Parse(s);
		}

		



	}


}
