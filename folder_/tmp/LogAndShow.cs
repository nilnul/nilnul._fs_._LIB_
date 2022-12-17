using System;
using System.Collections;
using System.Diagnostics;

namespace nilnul.fs.folder_.tmp
{
	static public class _LogAndShowX
	{

		static public void LogAndShow(string content, string prefix = "")
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

		static public void LogTimedAndShow(string content, string prefix = "")
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

		/// <summary>
		/// to avoid ambiguity of(string) between (string, null) and (string, "")
		/// </summary>
		/// <param name="content"></param>

		static public void LogTimedAndShow(string content)
		{
			LogTimedAndShow(content, "");
		}


		static public void LogTimedAndShow(string content, object prefix = null)
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


		static public void LogTimedAndShow(object content, string prefix = "")
		{
			LogTimedAndShow(content.ToString(), prefix);
		}


		static public void LogAndShow(object content, string prefix = "")
		{
			LogAndShow(content.ToString(), prefix);
		}

		static public void LogAndShow(IEnumerable content, string prefix = "")
		{
			LogAndShow(content.ToString(), prefix);
		}




		static public void LogAndShow(Func<string> content, string prefix = "")
		{
			LogAndShow(prefix, content());
		}



	}
}
