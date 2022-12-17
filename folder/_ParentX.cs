namespace nilnul.fs.folder
{
	static public class _ParentX
	{
		static public nilnul.fs.FolderI Nulable(nilnul.fs.FolderI folder)
		{
			//var parent = System.IO.Directory.GetParent(folder.ToString());//buggy for c:\a\b returns c:\a, while c:\a\b\ return c:\a\b
			var parent = nilnul.fs.folder.to_.Info.Singleton.to(folder).Parent;
			if (parent == null)
			{
				return null;
			}

			return new nilnul.fs.Folder(parent);
		}


	}
}
