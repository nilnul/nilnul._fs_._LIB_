using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders_
{
	static public class _UnLinkX
	{
		static public IEnumerable<nilnul.fs.FolderI> Filter(IEnumerable<nilnul.fs.FolderI> folders)
		{
			return folders.Where(x => nilnul.fs.folder.be_.Normal.Singleton.be(x));
		}

		static public IEnumerable<nilnul.fs.FolderI> Filter(IEnumerable<nilnul.fs.address_.ShieldI> folders)
		{
			return Filter(folders.Select(x => new nilnul.fs.Folder(x)));
		}

		static public IEnumerable<nilnul.fs.FolderI> Filter(IEnumerable<nilnul.fs.AddressI> folders)
		{
			return Filter(folders.Select(x => new nilnul.fs.Folder(x)));
		}

		static public IEnumerable<nilnul.fs.FolderI> Filter_ofAddresses(IEnumerable<string> folders)
		{
			return Filter(folders.Select(x => nilnul.fs.Folder.FroAddress(x)));
		}




	}
}
