using System.IO;

namespace nilnul.fs.folder_.tmp
{
	static public class _CreateLogX
	{
		static public StreamWriter CreateLog(string prefix, out string address)
		{
			var tmp = nilnul.fs.folder_._TmpX.Ensure();

			return System.IO.File.AppendText(
					address = new nilnul.fs.folder.denote_.MainVered(tmp).nextAddress(prefix, "txt")
			);

		}


		static public StreamWriter CreateLogTimed(string prefix, out string address)
		{

			return System.IO.File.AppendText(
					address = System.IO.Path.Combine(System.IO.Path.GetTempPath(), (prefix ?? "") + nilnul.time_.datetime.phrase_.Full.Singleton.phrase() + ".txt")
			);

		}

		static public StreamWriter CreateLogTimed(object prefix, out string address)
		{

			return CreateLogTimed(prefix?.ToString(), out address);

		}



	}
}
