using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	public class Docs
	{
		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			return folder.EnumerateFiles().Select(x => x.Name);
		}

		static public IEnumerable<string> Enumerate(string folderAddress)
		{
			return Enumerate(new DirectoryInfo(folderAddress));
		}



		static public bool Contain(nilnul.fs.Folder folder, string pattern)
		{

			return ((DirectoryInfo)folder).GetFiles(pattern).Any();
		}



		static public bool ContainAll(nilnul.fs.Folder folder, params string[] s)
		{

			return s.All(a => Contain(folder, a));
		}



	}
}
