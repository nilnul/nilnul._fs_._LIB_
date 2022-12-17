namespace nilnul.fs.folder.dir_.dst.to_
{
	static public class _ElementX
	{
		static public nilnul.fs.address_.SpearI To(FolderI container, nilnul.fs._address.DocI dst)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(
				container.address.en
				,
				dst
			);
		}
		static public nilnul.fs.address_.SpearI To(FolderI container, nilnul.fs._address.Doc dst)
		{
			return To(container, (_address.DocI)dst);
		}

		static public nilnul.fs.address_.SpearI To(nilnul.fs.FolderI container, nilnul.fs._address.DstA dst)
		{
			return To(container, new _address.Doc(dst));

			//System.IO.Path.Combine(container.ToString(), dst.ToString()));
		}


		static public nilnul.fs.address_.SpearI To(nilnul.fs.FolderI container, string dst)
		{
			return To(
				container
				,
				 new _address.Doc(dst)
			);
		}





	}
}
