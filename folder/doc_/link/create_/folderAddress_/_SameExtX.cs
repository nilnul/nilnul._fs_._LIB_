namespace nilnul.fs.folder.doc_.link.create_.folderAddress_
{
	static public class _SameExtX
	{
		static public void Exe(
			string folderAddress
			,
			string docMain
			,
			string target
		)
		{


			Exe(
				folderAddress
				,
				docMain
				,
				nilnul.fs.address_.Spear.Parse(target)

			);
		}

		static public void Exe(
			string folderAddress
			,
			string docMain
			,
			 nilnul.fs.address_.SpearI target
		)
		{


			var ext = nilnul.fs._address.doc_.exted._ExtX.Ext(
				new nilnul.fs.address_.spear_.ParentDoc(target).doc
			);

			_FolderAddressX.Exe(
				folderAddress
				,

				new nilnul.fs._address.doc_.MainExt(docMain, ext)

				,
				target

			);
		}

	}
}
