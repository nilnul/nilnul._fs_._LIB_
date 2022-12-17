using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.locations
{

	static public class _DivisionsX
	{
		static public IEnumerable<File0FolderI> File0FolderS(IEnumerable<File0FolderI> dirs)
		{


			return dirs.SelectMany(
				x => nilnul.fs.location._DivisionsX.File0FolderS(x)
			);
		}

		static public IEnumerable<File0FolderI> File0FolderS_ofAddresses(IEnumerable<string> dirs)
		{
			return File0FolderS(dirs.Select(x => nilnul.fs._File0FolderX.File0Folder_ofAddress(x)));
		}


		static public IEnumerable<File0FolderI> File0FolderS_ofAddresses(params string[] dirs)
		{
			return File0FolderS_ofAddresses(dirs as IEnumerable<string>);
		}

		public static IEnumerable<File0FolderI> File0FolderS(IEnumerable<AddressI> shields)
		{
			return File0FolderS(
				shields.Select(x => nilnul.fs._File0FolderX.File0Folder(x))
			);
		}

		static public IEnumerable<string> AddressesInTxts_ofAddresses(IEnumerable<string> folders)
		{
			return File0FolderS_ofAddresses(folders).Select(x => x.ToString());

		}


	}
}
