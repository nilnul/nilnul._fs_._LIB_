using System.Collections.Generic;

namespace nilnul.fs.location
{

	static public class _DivisionsX
	{
		static public IEnumerable<nilnul.fs.File0FolderI> File0FolderS(nilnul.fs.File0FolderI dir)
		{

			switch (dir)
			{
				case nilnul.fs.FileI file:
					return new[] { file };
				case nilnul.fs.FolderI folder:
					return nilnul.fs.folder._DivisionsX.Locations(folder);

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public IEnumerable<nilnul.fs.File0FolderI> File0FolderS(string dir)
		{

			return File0FolderS(_File0FolderX.File0Folder_ofAddress(dir));
		}


	}
}
