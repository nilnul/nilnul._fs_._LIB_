namespace nilnul.fs.folder
{
	static public class _DocX
	{
		static public nilnul.fs.address_.SpearI Spear(nilnul.fs.FolderI folder, _address.DocI doc)
		{
			return new address_.spear_.ParentDoc(folder.address.en, doc);
		}
		static public nilnul.fs.address_.SpearI Spear(nilnul.fs.FolderI folder, _address.Doc doc)
		{
			return Spear(folder, (_address.DocI)doc);
		}

		static public nilnul.fs.address_.SpearI Spear(nilnul.fs.FolderI folder, string doc)
		{
			return Spear(folder, new _address.Doc(doc));
		}

		static public nilnul.fs.address_.SpearI Spear_ofFolderAddress(string folder, string doc)
		{
			return new address_.spear_.ParentDoc(nilnul.fs.address_.Shield.Parse(folder), new _address.Doc(doc));
		}

		public static nilnul.fs.FileI CreateFroContainerDoc(FolderI folder, _address.DocI doc)
		{

			return new nilnul.fs.File(
				new nilnul.fs.address_.spear_.ParentDoc(
					folder.address.en
					,
					doc
				)
			);
		}


		public static nilnul.fs.FileI CreateFroContainerDoc(Folder folder, _address.DocI doc)
		{

			return CreateFroContainerDoc((FolderI)folder, doc);
		}

		public static nilnul.fs.FileI CreateFroContainerDoc(Folder folder, _address.Doc doc)
		{

			return CreateFroContainerDoc(folder, (_address.DocI)doc);
		}


		public static nilnul.fs.FileI CreateFroContainerDoc(Folder folder, string doc)
		{
			return CreateFroContainerDoc(folder, new _address.Doc(doc));

		}


	}
}
