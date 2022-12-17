using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file
{
	[Obsolete()]
	static public class _OpenX
	{
		/// <summary>
		/// by process start
		/// </summary>
		/// <param name="file"></param>
		static public void Open(nilnul.fs.File file) {

			Process.Start(file.address.ToString());

		}

		static public void Open(string  file) {

			Open( new nilnul.fs.File(file));

		}

		static public void Open(nilnul.fs.FileI1 file) {
			Process.Start(file.ToString());
		}

	}
}
