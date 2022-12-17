using System.Collections;
using System.Collections.Generic;

namespace nilnul.fs.folders
{
	public interface VowI : nilnul.obj.VowI<nilnul.fs.FoldersI>
	{
	}

	public interface VowOfSeqI :
		nilnul.obj.VowI2<
			IEnumerable<nilnul.fs.FolderI>
		>
		{ }
}
