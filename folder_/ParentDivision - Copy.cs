using System;

namespace nilnul.fs.folder_
{
		[Obsolete(nameof(_BaseDivisionX))]
	static public class _ParentDivisionX1
	{
		[Obsolete("not create,but vow it is a folder")]
		static public nilnul.fs.FolderI CreateFolder(nilnul.fs.FolderI parent, nilnul.fs._address.DivisionI division)
		{
			return new nilnul.fs.Folder(
				 nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(parent.address.en, division)
			);
		}

		[Obsolete("not create,but vow it is a folder")]
		static public nilnul.fs.FolderI CreateFolder(nilnul.fs.FolderI parent, string division)
		{
			return CreateFolder(parent, _address.DivisionA.Parse(division));
		}

	}
}
