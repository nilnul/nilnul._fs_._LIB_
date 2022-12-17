using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder
{
	[Obsolete(nameof(_DivsX1))]
	public class Divs
	{
		static public IEnumerable<DirectoryInfo> Enumerate(DirectoryInfo dir) {
			foreach (var item in dir.EnumerateDirectories())
			{
				foreach (var item1 in Enumerate(item))
				{
					yield return item1;

				}
			}

			yield return dir;
		}


		static public IEnumerable<nilnul.fs.Folder> Enumerate(nilnul.fs.Folder dir) {
			foreach (var item in ((DirectoryInfo)dir).EnumerateDirectories())
			{
				foreach (var item1 in Enumerate(item))
				{
					yield return  (nilnul.fs.Folder)item1;

				}
			}

			yield return dir;
		}


		static public IEnumerable<string> Enumerate(string folder) {
			foreach (var item in System.IO.Directory.EnumerateDirectories(folder))
			{
				foreach (var item1 in Enumerate(item))
				{
					yield return item1;

				}
			}

			yield return folder;
		}

	}
}
