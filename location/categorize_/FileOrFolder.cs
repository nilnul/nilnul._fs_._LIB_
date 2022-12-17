using System.IO;

namespace nilnul.fs.location.categorize_
{
	static public class _FileOrFolderX
	{
		public static bool Categorize(string address)
		{
			FileAttributes attr = System.IO.File.GetAttributes(address);

			if (attr.HasFlag(FileAttributes.Directory))
				return true;
			else
				return false;

		}
	}
}
