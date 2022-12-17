using nilnul.fs._address;
using System;

namespace nilnul.fs.folder.docs
{

	static public class _NoneX
	{
		static public bool None(this nilnul.fs.FolderI folder, Func<DocI, bool> func)
		{
			return nilnul.obj.seq.be_._NoneX.None(
				nilnul.fs.folder._DocsX.Docs(folder)
				,
				func
			);
		}
		static public bool None(this nilnul.fs.FolderI folder)
		{
			return nilnul.obj.seq.be_._NoneX.None(
				nilnul.fs.folder._DocsX.Docs(folder)

			);

		}


	}
}
