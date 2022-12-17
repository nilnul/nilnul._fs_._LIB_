using System.Collections;
using System.Collections.Generic;

namespace nilnul.fs.folders
{
	/*extern alias obj;*/
	public interface BeI :
		/*obj::*/nilnul.obj.BeI1<nilnul.fs.FoldersI>
	{

	}

	public interface BeOfSeqI :
		nilnul.obj.BeI1<IEnumerable<nilnul.fs.FolderI>>
		{

	}
}
