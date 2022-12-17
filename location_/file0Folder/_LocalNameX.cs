using System.Collections.Generic;

namespace nilnul.fs.location_.file0Folder
{
	static public class _LocalNameX
	{
		static public string LocalName(File0FolderI file0Folder) {
			switch (file0Folder)
			{
				case FileI file:
					return nilnul.fs.file._DocX.Doc(file).ToString();
				case FolderI folder:
					return nilnul.fs.folder._LocalNameX.LocalName(folder);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}
	}
}
