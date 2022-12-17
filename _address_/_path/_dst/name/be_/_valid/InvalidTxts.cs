using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt;
using System.Text.RegularExpressions;

namespace nilnul.fs._address_._path._dst.name.be_._valid
{
	public class InvalidTxts
		: nilnul.txt.SetI
	{


		public static Regex lpts = new Regex(@"^LPT\d?$", RegexOptions.IgnoreCase);
		public static Regex coms = new Regex(@"^COM\d?$", RegexOptions.IgnoreCase);
		public static string[] reserved = new[] {
			"CON", "PRN", "AUX", "CLOCK$", "NUL",

		};

		public bool contains(string element)
		{
			return lpts.IsMatch(element) 
				//|| coms.IsMatch(element)  //i saw dir named "com"
				|| nilnul.txt.set.be_._ContainX.Contain_caseInsensitive(reserved, element) 
				||
				(element == "." || element=="..")
				;

			//throw new NotImplementedException();
		}


		static public readonly InvalidTxts Singleton = SingletonByDefault<InvalidTxts>.Instance;

	}
}
