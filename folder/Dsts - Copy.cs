using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	[Obsolete()]
	static public class _Dsts
	{
		static public IEnumerable<string> Addresses_ofAddress(string folderAddress)
		{
			return System.IO.Directory.EnumerateFileSystemEntries(
				nilnul.fs.address._OverlongX.PrependIfNeed(folderAddress)
			);
		}

		static public IEnumerable<File0FolderI> Locations(string folderAddress)
		{
			

			return Addresses_ofAddress(folderAddress).Select(x=> nilnul.fs.LocationA.Location(x));
		}

		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			//return Addresses_ofAddress(folder.ToString());
			return  folder.EnumerateDirectories().Select(
				x => x.Name + System.IO.Path.DirectorySeparatorChar/*.ToString()*/
			).Concat(
				folder.EnumerateFiles().Select(x => x.Name)
			);
		}

		static public IEnumerable<string> Enumerate(string folderAddress)
		{
			return Enumerate(new DirectoryInfo(folderAddress));
		}

		public static IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.FolderI folder)
		{
			return Enumerate(folder.ToString()).Select(x => nilnul.fs._address.DstA.Parse(x));
		}

		public static IEnumerable<nilnul.fs._address.DstI> Dsts(DirectoryInfo folder)
		{
			return Enumerate(folder.ToString()).Select(x => nilnul.fs._address.DstA.Parse(x));
		}


		static public IEnumerable<File0FolderI> Locations(DirectoryInfo folder)
		{

			return Locations(folder.ToString());
			#region throw exception NotFound if path too long
			//return folder.EnumerateFileSystemInfos().Select(x => nilnul.fs.LocationA.Location(x));

			#endregion

		}




		public static IEnumerable<File0FolderI> Locations(FolderI parent)
		{
			return Locations(
				nilnul.fs.folder.to_._InfoX.To(parent)
			);
		}


	}
}
