using System;

namespace nilnul.fs
{


	static public class _File0FolderX
	{



		static public nilnul.fs.File0FolderI File0Folder(nilnul.fs.address_.Shield0SpearI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.ShieldI shield:
					return new nilnul.fs.Folder(shield);
				case nilnul.fs.address_.SpearI spear:
					return nilnul.fs.location_.Spear.File0Folder(spear);

				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		public static File0FolderI File0Folder(AddressI en)
		{
			return File0Folder(nilnul.fs.address_._Shield0SpearX.Parse(en));
			//throw new NotImplementedException();
		}
		public static File0FolderI File0Folder(nilnul.fs.address_.Location address)
		{
			return File0Folder(address.en);
			throw new NotImplementedException();
		}
		static public nilnul.fs.File0FolderI File0Folder(nilnul.fs.LocationI address)
		{
			switch (address)
			{
				case nilnul.fs.FileI shield:
					return shield;
				case nilnul.fs.FolderI spear:
					return spear;
				default:
					return File0Folder(address.address);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public nilnul.fs.File0FolderI File0Folder_ofAddress(string address)
		{
			return File0Folder(nilnul.fs.address_._Shield0SpearX.Parse(address));
		}





	}

}
