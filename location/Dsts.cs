using nilnul.fs._address;
using System;
using System.Collections.Generic;

namespace nilnul.fs.location
{

	static public class _DstsX
	{
		static public IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.File0FolderI dir)
		{

			switch (dir)
			{
				case nilnul.fs.FileI file:
					return new nilnul.fs._address.DstI[] { };
				case nilnul.fs.FolderI folder:
					return nilnul.fs.folder._Dsts.Dsts(folder);

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		public static IEnumerable<DstI> Dsts(AddressI address)
		{
			return Dsts( nilnul.fs._File0FolderX.File0Folder(address));

		}

		static public IEnumerable<nilnul.fs._address.DstI> Dsts(string dir)
		{

			return Dsts(_File0FolderX.File0Folder_ofAddress(dir));
		}


	}
}
