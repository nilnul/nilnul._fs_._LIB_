using nilnul.fs.address_;

namespace nilnul.fs.folder.doc_.link.create_
{
	static public class _FolderAddressX
	{
		static public void Exe(
			string folderAddress
			,
			string doc
			,
			string target
		)
		{
			_LinkX.Create(
				nilnul.fs.Folder.FroAddress(folderAddress)
				,
				new nilnul.fs._address.Doc(doc)
				,
				 nilnul.fs.address_.Spear.Parse(target)
			);
		}

		public static void Exe(string folderAddress, _address.DocI dotted1, SpearI target)
		{
			_LinkX.Create(
				nilnul.fs.Folder.FroAddress(folderAddress)
				,
				dotted1
				,
				 target
			);
			//throw new NotImplementedException();
		}
	}
}
