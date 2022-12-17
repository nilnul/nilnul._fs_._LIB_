using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.destinations_
{
	static public class _SymlinksX
	{
		static public IEnumerable<nilnul.fs.File0FolderI> Locations(nilnul.fs.Folder folder)
		{
			return Destinations.Locations(folder).Where(
#pragma warning disable CS0612 // 'Symlink' is obsolete
				x => nilnul.fs.location.be_.Symlink.Singleton.be(x)
#pragma warning restore CS0612 // 'Symlink' is obsolete
			);
		}

		static public IEnumerable<string> Addresses(DirectoryInfo folder)
		{
			return Locations(
				(nilnul.fs.Folder)folder
			).Select(
				x => x.ToString()
			);
		}

	}
}