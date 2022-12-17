using System.Collections.Generic;

namespace nilnul.fs.location_.file0Folder
{
	static public class _ParentX
	{
		static public nilnul.fs.FolderI FolderNulable(File0FolderI file0Folder) {
			switch (file0Folder)
			{
				case FileI file:
					return nilnul.fs.file._ContainerX.Folder(file);
				case FolderI folder:
					return nilnul.fs.folder._ParentX.Nulable(folder);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}
	}
}
