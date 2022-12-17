using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dsts_
{
	static public class _SymlinksX
	{
		static public IEnumerable<string> Enumerate(nilnul.fs.Folder folder)
		{
			return _Dsts.Enumerate(folder).Where(
#pragma warning disable CS0612 // 'Symlink' is obsolete
#pragma warning disable CS0618 // 'Symlink.be(string)' is obsolete: 'wrong?'
				x => nilnul.fs.location.be_.Symlink.Singleton.be(x)
#pragma warning restore CS0618 // 'Symlink.be(string)' is obsolete: 'wrong?'
#pragma warning restore CS0612 // 'Symlink' is obsolete
			);
		}

		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			return Enumerate(
				(nilnul.fs.Folder)folder
			);
		}

	}
}