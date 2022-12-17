using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.ext.be_
{
	static public class _DottedWithGeOneCharsX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="spear">
		///	assume is a full path, not a relative path such as "myFile.txt"
		/// </param>
		/// <returns></returns>
		static public bool _Be_assumeSpear(string spear) {
			///true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the path include a period (.) followed by one or more characters; otherwise, false.
			///// HasExtension('myfile.ext') returns True
			// HasExtension('mydir\myfile') returns False
			// HasExtension('C:\mydir.ext\') returns False

			return System.IO.Path.HasExtension(spear);
		}
	}
}
