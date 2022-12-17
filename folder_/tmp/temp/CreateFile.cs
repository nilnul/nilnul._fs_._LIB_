using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.temp
{
	static public class _CreateFileX
	{
		static public FileStream Ensure(string prefix,string ext,  out string address) {

			return System.IO.File.Create(
					address= new nilnul.fs.folder.dsts.Ver(System.IO.Path.GetTempPath()).getNextAddress(prefix, ext)
			);
			
		}




	}
}
