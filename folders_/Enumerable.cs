using System.Collections.Generic;

namespace nilnul.fs.folders_
{
	public class Enumable
		: nilnul.objs_.Enumable<nilnul.fs.FolderI>
		,
		FoldersI
	{
		public Enumable(IEnumerable<FolderI> enumerable) : base(enumerable)
		{
		}
	}
}
