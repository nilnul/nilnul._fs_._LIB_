namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// clear
	/// </summary>
	/// alias:
	///		vacant
	///		clear
	public class NoDocuments
		:
		BeA,
		BeI
	{
		public override bool be(nilnul.fs.FolderI obj)
		{
			return nilnul.objs.be_._NoneX.None(
				nilnul.fs.folder._DocumentsX.Files(obj)
			);
			//throw new NotImplementedException();
		}


		static public readonly NoDocuments Singleton = nilnul.obj.SingletonByDefault<NoDocuments>.Instance;


		public static bool _Be_ofAddress(string selectedPath)
		{
			return Singleton.be(Folder.FroAddress(selectedPath));

			//throw new NotImplementedException();
		}

		


	}
}
