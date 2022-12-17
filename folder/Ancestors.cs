using System.Collections.Generic;

namespace nilnul.fs.folder
{
	static public class _AncestorsX
	{
		static public IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			var current = nilnul.fs.folder._ParentX.Nulable(folder);
			while (
				current != null
			)
			{
				yield return current;
				current = nilnul.fs.folder._ParentX.Nulable(current);

			}
		}
	}
}
