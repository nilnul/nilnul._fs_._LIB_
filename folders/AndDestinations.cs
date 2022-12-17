using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders
{

	[Obsolete(nameof(_DivisionsX))]
	public class AndDestinations
	{
		static public IEnumerable<FileSystemInfo> Enumerate(IEnumerable<DirectoryInfo> dirs) {
			return dirs.SelectMany(
				x=> nilnul.fs.folder.AndDestinations.Enumerate(x)
			);
		}

		static public IEnumerable<string> Enumerate(IEnumerable< string> folders) {
				return folders.SelectMany(
				x=> nilnul.fs.folder.AndDestinations.Enumerate(x)
			);
		
		}

		public static IEnumerable<nilnul.fs.LocationI> Enumerate(IEnumerable<Folder> dirs)
		{
			return dirs.SelectMany(
				x=> nilnul.fs.folder.AndDestinations.Enumerate(x)
			);

			throw new NotImplementedException();
		}
	}
}
