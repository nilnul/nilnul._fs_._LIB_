using System;

namespace nilnul.fs.location_
{
	public abstract class File0FolderA
	{
		static public nilnul.fs.File0FolderI Parse(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.SpearI spear:
					if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
					{
						return new nilnul.fs.File(spear);
					}
					else if (nilnul.fs.address_.spear.be_.Folder.Singleton.be(spear))
					{
						return new nilnul.fs.Folder(spear);
					}
					else
					{
						throw new ArgumentException($"Spear:{spear} is not location");
					}
					break;
				case nilnul.fs.address_.ShieldI shield:
					if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(shield))
					{
						return new nilnul.fs.Folder(shield);
					}
					else
					{
						throw new ArgumentException($"Spear:{shield} is not location");
					}

				default:
					throw new UnexpectedTypeException($"unexpected address subtype:{address.GetType()}:{address}");
					break;
			}
		}

		static public nilnul.fs.File0FolderI Parse(string x)
		{
			return Parse( nilnul.fs.AddressA.Parse(x) );
		}

		static public nilnul.fs.File0FolderI Parse(
			nilnul.fs._location_.BlankI location
		)
		{
			switch (location)
			{
				case nilnul.fs.FileI file:
					return file;
				case nilnul.fs.FolderI folder:
					return folder;
				default:
					return Parse(location.ToString());
					break;
			}
		}


	}
}
