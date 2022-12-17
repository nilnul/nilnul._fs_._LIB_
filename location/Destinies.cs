using System.Collections.Generic;

namespace nilnul.fs.location
{

	static public class _DestinationsX
	{
		static public IEnumerable<nilnul.fs.File0FolderI> File0folders(nilnul.fs.File0FolderI dir)
		{

			switch (dir)
			{
				case nilnul.fs.FileI file:
					return null;	///to avoid confusion as some folder may return empty.<see cref="nameof()"/>
				case nilnul.fs.FolderI folder:
					return nilnul.fs.folder.Destinations.Locations(folder);

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public IEnumerable<nilnul.fs.File0FolderI> File0folders(string dir)
		{

			return File0folders(_File0FolderX.File0Folder_ofAddress(dir));
		}


	}
}
