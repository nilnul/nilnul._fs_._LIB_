using System.Collections.Generic;

namespace nilnul.fs.location
{

	/// <summary>
	/// binary linear object.
	/// </summary>
	static public class _BlobX
	{
		static public byte[] File0folders(nilnul.fs.File0FolderI dir)
		{

			switch (dir)
			{
				case nilnul.fs.FileI file:
					return nilnul.fs.file._BlobX.Blob(file);	
				case nilnul.fs.FolderI folder:
					return null;	///to avoid confusion as some file may return empty.<see cref="nameof()"/>

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		static public byte[] File0folders(string dir)
		{

			return File0folders(_File0FolderX.File0Folder_ofAddress(dir));
		}


	}
}
