using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs._folder
{
	
	static public class X
	{
		static public bool Exists(string location) {
			return Directory.Exists(location);
		}

		static public string CreateVersionedFolder(string folder, string prefix)
		{


			var folderInfo = new DirectoryInfo(folder);

			var allSubFolders = Directory.EnumerateDirectories(folder, prefix);

			var candidate = prefix;

			for (int i = 0; i < int.MaxValue; i++)
			{
				candidate = prefix + nilnul.txt.on.NumX.ToTxt_zeroNul(i);

				if (!ContainsSubFolder(folder, candidate))
				{
					var candidatePath = Path.Combine(folder, candidate);
					Directory.CreateDirectory(candidatePath);

					return candidate;
				}


			}

			throw new Exception();
		}

		static public bool ContainsSubFolder(string folder, string sub)
		{

			return new DirectoryInfo(folder).EnumerateDirectories(sub).Any();
		}



	}
}
