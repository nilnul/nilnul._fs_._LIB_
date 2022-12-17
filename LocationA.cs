using nilnul.fs.address_;
using System;
using System.IO;

namespace nilnul.fs
{
	public abstract class LocationA : LocationI
	{
		public abstract Location address { get; }

		[Obsolete()]
		static public File0FolderI Location(System.IO.FileSystemInfo info) {
			if (info is System.IO.FileInfo file)
			{
				return new nilnul.fs.File(file);
			}
			return new nilnul.fs.Folder(
				(DirectoryInfo)info
			);

		}

		static public File0FolderI Location1(System.IO.FileSystemInfo info) {
			if (info is System.IO.FileInfo file)
			{
				return new nilnul.fs.File1(file);
			}
			return new nilnul.fs.Folder1(
				(DirectoryInfo)info
			);
		}



		[Obsolete()]
		public static File0FolderI Location_assumeSpearShield(nilnul.fs.AddressI folderAddress)
		{
			if (folderAddress is nilnul.fs.address_.ShieldI shield)
			{
				return new nilnul.fs.Folder(shield);
			}
			var spear = (nilnul.fs.address_.SpearI)folderAddress;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return new nilnul.fs.File(spear);
			}
			return nilnul.fs.Folder.FroAddress(spear);
		}

		public static File0FolderI Location_assumeSpearShield(nilnul.fs.AddressI1 folderAddress)
		{
			if (folderAddress is nilnul.fs.address_.ShieldI1 shield)
			{
				return new nilnul.fs.Folder1(shield);
			}
			var spear = (nilnul.fs.address_.SpearI1)folderAddress;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return new nilnul.fs.File1(spear);
			}
			return nilnul.fs.Folder1.FroAddress(spear);
		}

		[Obsolete()]
		public static File0FolderI Location(string folderAddress)
		{
			return Location_assumeSpearShield(nilnul.fs.AddressA.Parse(folderAddress));
		}

		public static File0FolderI Location1(string folderAddress)
		{
			return Location_assumeSpearShield(nilnul.fs.AddressA1.Parse(folderAddress));
		}

		[Obsolete()]
		public static File0FolderI Location(nilnul.fs.address_.Shield0SpearI folderAddress)
		{
			if (folderAddress is nilnul.fs.address_.ShieldI shield)
			{
				return new nilnul.fs.Folder(shield);
			}
			var spear = (nilnul.fs.address_.SpearI)folderAddress;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return new nilnul.fs.File(spear);
			}
			return nilnul.fs.Folder.FroAddress(spear);
		}

		public static File0FolderI Location1(nilnul.fs.address_.Shield0SpearI folderAddress)
		{
			if (folderAddress is nilnul.fs.address_.ShieldI1 shield)
			{
				return new nilnul.fs.Folder1(shield);
			}
			var spear = (nilnul.fs.address_.SpearI1)folderAddress;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return new nilnul.fs.File1(spear);
			}
			return nilnul.fs.Folder1.FroAddress(spear);
		}


	}


}
