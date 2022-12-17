using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address
{
	static public class _UrlX
	{
		public const string ORIGIN = "file";
		public const string PROTOCOL = ORIGIN+":";

		public static string Unprefix(string x) {
			if (x.StartsWith(PROTOCOL) )
			{
				return x.Substring(PROTOCOL.Length)
					.TrimStart('\\', '/')		// such as file:/, file: //, file:///, file://///
				;
			}
			return x;
		}
	}
}
