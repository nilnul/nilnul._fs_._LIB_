using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.address_.spear.be_
{
	static public class _FileX_splitOverlong
	{
		

		const int MAX_PATH = 260;
		private static bool _ofLongPath(string path)
		{
			string[] subpaths = path.Split('\\', '/');
			StringBuilder sbNewPath = new StringBuilder(subpaths[0]);

			// Build longest subpath that is less than MAX_PATH characters
			for (int i = 1; i < subpaths.Length; i++)
			{
				if (sbNewPath.Length + 1+subpaths[i].Length >= MAX_PATH)
				{
					subpaths = subpaths.Skip(i).ToArray();
					break;
				}
				sbNewPath.Append("\\" + subpaths[i]);
			}
			DirectoryInfo dir = new DirectoryInfo(sbNewPath.ToString());
			bool foundMatch = dir.Exists;
			if (foundMatch)
			{
				// Make sure that all of the subdirectories in our path exist.
				// Skip the last entry in subpaths, since it is our filename.
				// If we try to specify the path in dir.GetDirectories(), 
				// We get a max path length error.
				int i = 0;
				while (i < subpaths.Length - 1 && foundMatch)
				{
					foundMatch = false;
					foreach (DirectoryInfo subDir in dir.GetDirectories())
					{
						if (
							nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
								subDir.Name, subpaths[i]
							)
						)
						{
							// Move on to the next subDirectory
							dir = subDir;
							foundMatch = true;
							break;
						}
					}
					i++;
				}
				if (foundMatch)
				{
					foundMatch = false;
					// Now that we've gone through all of the subpaths, see if our file exists.
					// Once again, If we try to specify the path in dir.GetFiles(), 
					// we get a max path length error.
					foreach (FileInfo fi in dir.GetFiles())
					{
						if (
							nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
								fi.Name, subpaths[subpaths.Length - 1]
							)
						)
						{
							foundMatch = true;
							break;
						}
					}
				}
			}
			return foundMatch;

		}

		public static bool _Be(string path)
		{
			if (path.Length >= MAX_PATH)
			{
				return _ofLongPath(path);
			}
			return System.IO.File.Exists(path);

		}

	}


}
