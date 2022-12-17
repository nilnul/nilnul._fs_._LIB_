namespace nilnul.fs.folder.doc_
{
	static public class _LinkX
	{
		static public void Create(
			nilnul.fs.FolderI folder,
			nilnul.fs._address.DocI doc,
			nilnul.fs.address_.SpearI target
		)
		{


			nilnul.fs.file_._SymlinkX.Create(
				new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, doc)
				, target

			);
		}


	}
}
