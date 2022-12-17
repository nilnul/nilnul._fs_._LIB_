using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.directory._toDocument
{
	static public class _TxtX
	{
		static public string ToDocument(string directory) {
			return directory.Substring(0, directory.Length-1);
		}
	}
}
