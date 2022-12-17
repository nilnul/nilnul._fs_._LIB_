using nilnul.fs._address;
using System;
using System.Linq;

namespace nilnul.fs.folder.docs
{

	static public class _AnyX
	{
		static public bool Any(this nilnul.fs.FolderI folder, Func<DocI, bool> func)
		{
			return nilnul.fs.folder._DocsX.Docs(folder).Any(func);
		}
		static public bool Any(this nilnul.fs.FolderI folder)
		{
			return nilnul.fs.folder._DocsX.Docs(folder).Any();
		}


	}
}
