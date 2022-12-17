using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.temp
{
	[Obsolete(nameof(tmp._CreateLogX))]
	static public class _CreateLogX
	{
		static public StreamWriter CreateLog(string prefix, out string address) {

			return System.IO.File.AppendText(
					address= new nilnul.fs.folder.dsts.Ver(System.IO.Path.GetTempPath()).getNextAddress(prefix, "txt")
			);
			
		}


		static public StreamWriter CreateLogTimed(string prefix, out string address) {

			return System.IO.File.AppendText(
					address=System.IO.Path.Combine( System.IO.Path.GetTempPath(), prefix+nilnul.time.to_.txt_.Iso.ToTxtFull()+ ".txt")
			);
			
		}





	}
}
