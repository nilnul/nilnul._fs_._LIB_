using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	static public class _Dsts1
	{
		static public IEnumerable<string> Addresses_ofAddress(string folderAddress)
		{
			return System.IO.Directory.EnumerateFileSystemEntries(
				nilnul.fs.address._OverlongX.PrependIfNeed(folderAddress)
			);
		}

		static public IEnumerable<File0FolderI> Locations(string folderAddress)
		{
			

			return Addresses_ofAddress(folderAddress).Select(x=> nilnul.fs.LocationA.Location1(x));
		}

		/// <summary>
		/// for dir, the txt is ended with deck;
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<string> DstAsTxtEs(DirectoryInfo folder)
		{
			//return Addresses_ofAddress(folder.ToString());
			return  folder.EnumerateDirectories().Select(
				x => x.Name + System.IO.Path.DirectorySeparatorChar/*.ToString()*/
			).Concat(
				folder.EnumerateFiles().Select(x => x.Name)
			);
		}

		[Obsolete(nameof(folder))]
		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			//return Addresses_ofAddress(folder.ToString());
			return  DstAsTxtEs(folder);
		}


		static public IEnumerable<string> _DstAsTxtEs_addressAssumeFolder(string folderAddress)
		{
			return DstAsTxtEs(new DirectoryInfo(folderAddress));
		}

		[Obsolete(nameof(_DstAsTxtEs_addressAssumeFolder))]
		static public IEnumerable<string> Enumerate(string folderAddress)
		{
			return Enumerate(new DirectoryInfo(folderAddress));
		}

		static public IEnumerable<string> DstAsTxtEs(nilnul.fs.FolderI1 folderAddress)
		{
			return _DstAsTxtEs_addressAssumeFolder(folderAddress.ToString());
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div.DstI> Dsts(nilnul.fs.FolderI1 folder)
		{
			return Enumerate(folder.ToString()).Select(x => nilnul.fs._address._route.division_._div.DstA.Parse(x));
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div.DstI> Dsts(DirectoryInfo folder)
		{
			return Enumerate(folder.ToString()).Select(x => nilnul.fs._address._route.division_._div.DstA.Parse(x));
		}


		static public IEnumerable<File0FolderI> Locations(DirectoryInfo folder)
		{

			return Locations(folder.ToString());
			#region throw exception NotFound if path too long
			//return folder.EnumerateFileSystemInfos().Select(x => nilnul.fs.LocationA.Location(x));

			#endregion

		}




		public static IEnumerable<File0FolderI> Locations(FolderI1 parent)
		{
			return Locations(
				nilnul.fs.folder.op_.to_._InfoX.To(parent)
			);
		}


	}
}
