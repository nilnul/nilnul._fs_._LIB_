using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.temp
{
	[Obsolete(nameof(tmp._LogAndShowX))]

	static public class _LogAndShowX
	{

		static public void LogAndShow( string content, string prefix="")
		{
			string address;

			using (
				var stateLog = _CreateLogX.CreateLog(prefix, out address)
			)
			{
				stateLog.Write(
					content
				);
			}

			Process.Start(address);
		}

		static public void LogTimedAndShow( string content, string prefix="")
		{
			string address;

			using (
				var stateLog = _CreateLogX.CreateLogTimed(prefix, out address)
			)
			{
				stateLog.Write(
					content
				);
			}

			Process.Start(address);
		}

		static public void LogTimedAndShow( object content, string prefix="")
		{
			LogTimedAndShow(content.ToString(),prefix);
		}


		static public void LogAndShow( object content, string prefix="")
		{
			LogAndShow(content.ToString(), prefix);
		}

		static public void LogAndShow( IEnumerable content, string prefix="")
		{
			LogAndShow(content.ToString(), prefix);
		}


		

		static public void LogAndShow(Func<string> content, string prefix="" )
		{
			LogAndShow(prefix, content());
		}



	}
}
