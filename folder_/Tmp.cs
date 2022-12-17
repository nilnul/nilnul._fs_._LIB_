namespace nilnul.fs.folder_
{
	public class _TmpX
	{
		static public nilnul.fs.FolderI Get()
		{
			return nilnul.fs.Folder.FroAddress(System.IO.Path.GetTempPath());
		}

		static public nilnul.fs.FolderI Ensure()
		{
			return nilnul.fs.folder._EnsureX.Folder_ofAddress(System.IO.Path.GetTempPath());
		}

	}
}
