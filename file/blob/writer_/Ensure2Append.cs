using System.IO;

namespace nilnul.fs.file.blob.writer_
{
	static public class _Ensure2AppendX
	{
		static public StreamWriter TxtStreamWriter(string path)
		{

			return System.IO.File.AppendText(path);
		}
	}
}
