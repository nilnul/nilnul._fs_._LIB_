using System;

namespace nilnul.fs.folder_
{
	static public class _BaseDivisionX
	{
		static public nilnul.fs.FolderI Folder(nilnul.fs.FolderI parent, nilnul.fs._address.DivisionI division)
		{
			return new nilnul.fs.Folder(
				 nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(parent.address.en, division)
			);
		}

		static public nilnul.fs.FolderI Folder(nilnul.fs.FolderI parent, string division)
		{
			return Folder(parent, _address.DivisionA.Parse(division));
		}

	}
}
