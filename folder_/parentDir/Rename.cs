namespace nilnul.fs.folder_.baseDir
{
	static public class _RenameX
	{

		static public void _Rename(nilnul.fs.address_.shield_.BaseDir folder, nilnul.fs._address.DocI newName)
		{

			if (nilnul.fs._address.doc.eq.Ne.Singleton.ne(new _address.Doc(folder.child.denote), newName))
			{
				System.IO.Directory.Move(
					folder.ToString()
					,

					 new nilnul.fs.address_.shield_.BaseDir(folder.parent, newName).ToString()
				);


			}

		}
		public static void Rename(address_.shield_.BaseDir baseChild, string newName)
		{
			_Rename(baseChild, new nilnul.fs._address.Doc(newName));
		}
		public static void Rename(folder_.ParentDir baseChild, string newName)
		{
			_Rename(baseChild, new nilnul.fs._address.Doc(newName));
		}

		static public void Rename(
			nilnul.fs.folder_.ParentDir folder
			,
			nilnul.fs._address.DocI newName
		)
		{

			_Rename(folder.en, newName);
		}



		static public void FolderInAddress(string folder, string newName)
		{

			Rename(

				nilnul.fs.address_.shield_.parentDir_._AddressX.Create(folder)
				,
				newName
			);

			//var address = nilnul.fs.Address1.Parse(folder);

			//var shield = nilnul.fs.address_.shield_._AddressX.Create(address);



			//Rename(
			//	nilnul.fs.folder_.BaseDir..p
			//);
		}

	}
}
