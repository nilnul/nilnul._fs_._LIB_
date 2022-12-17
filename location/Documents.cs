using System.Collections.Generic;

namespace nilnul.fs.location
{

	static public class _DocumentsX
	{
		static public IEnumerable<nilnul.fs.FileI> FileS(nilnul.fs.File0FolderI dir)
		{

			switch (dir)
			{
				case nilnul.fs.FileI file:
					return new[] { file };
				case nilnul.fs.FolderI folder:
					return nilnul.fs.folder._DocumentsX.Files(folder);

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public IEnumerable<nilnul.fs.FileI> FileS(string dir)
		{

			return FileS(_File0FolderX.File0Folder_ofAddress(dir));
		}


	}
}
