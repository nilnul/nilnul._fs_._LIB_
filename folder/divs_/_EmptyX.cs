using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folder.divs_
{
	static public class _EmptyX
	{
		static public IEnumerable<nilnul.fs.FolderI> Folders(
			nilnul.fs.FolderI folder
		)
		{
			return nilnul.fs.folder._DivsX1.Folders(folder).Where(
				x => nilnul.fs.folder.be_.Empty.Singleton.be(x)
			);
		}

		static public IEnumerable<nilnul.fs._address.Div> Divs(
			nilnul.fs.FolderI folder
		)
		{
			return Folders(folder).Select(
				x => nilnul.fs.folder.co_.sup._DifX._Div(folder, x)
			);
		}

		static public IEnumerable<nilnul.fs._address.Div> Divs(
			nilnul.fs.AddressI folder
		)
		{
			return Divs(
				new nilnul.fs.Folder(folder)
			);
		}



	}
}
