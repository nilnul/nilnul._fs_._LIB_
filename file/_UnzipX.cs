using System.IO.Compression;

namespace nilnul.fs.file
{
	public class _UnzipX
	{
		public static ZipArchive Archive(string pathToZip)
		{
			return ZipFile.OpenRead(pathToZip);

		}
	}
}
