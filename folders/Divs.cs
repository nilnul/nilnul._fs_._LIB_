using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folders
{

	public class Divs
	{
		static public IEnumerable<DirectoryInfo> Infos(IEnumerable<DirectoryInfo> dirs)
		{
			return dirs.SelectMany(
				x => nilnul.fs.folder._DivsX1.Infos(x)
			);
		}

		static public IEnumerable<DirectoryInfo> Infos_ofAddresses(IEnumerable<string> dirs)
		{
			return Infos(
				dirs.Select(
					d=> new DirectoryInfo(d)
				)
			);
		}

		static public IEnumerable<DirectoryInfo> Infos_ofAddresses(params string[] dirs)
		{
			return Infos_ofAddresses(
				(IEnumerable<string>)dirs
			);
		}

		static public IEnumerable<string> Addresses_ofAddresses(IEnumerable<string> folders)
		{
			return folders.SelectMany(
			x => nilnul.fs.folder._DivsX1.Addresses_ofAddress(x)
		);

		}

		public static IEnumerable<nilnul.fs.FolderI> Enumerate(IEnumerable<FolderI> dirs)
		{
			return dirs.SelectMany(
				x => nilnul.fs.folder._DivsX1.Folders(x)
			);

		}
	}
}
