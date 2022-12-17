using nilnul.fs._address;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{

	/// <summary>
	/// the documents and the directories
	/// </summary>
	public class Destinations
	{
		static public IEnumerable<System.IO.FileSystemInfo> Infos(DirectoryInfo dir)
		{
			foreach (var item in dir.EnumerateFiles())
			{
				yield return item;

			}

			foreach (var item in dir.EnumerateDirectories())
			{
				yield return item;

				foreach (var item1 in Infos(item))
				{
					yield return item1;

				}
			}
		}


		static public IEnumerable<nilnul.fs.File0FolderI> Locations(nilnul.fs.FolderI dir)
		{
			return Infos(
				nilnul.fs.folder.to_._InfoX.To(
				dir
				)
			).Select(x => nilnul.fs.file0Folder_._InfoX.File0Folder(x));
		}

		static public IEnumerable<nilnul.fs.File0FolderI> Locations(nilnul.fs.Folder dir)
		{
			return Infos((DirectoryInfo)dir).Select(x => nilnul.fs.file0Folder_._InfoX.File0Folder(x));
		}


		static public IEnumerable<string> Addresses_ofAddress(string folder)
		{
			return Infos(new DirectoryInfo(folder)).Select(x => x.FullName);
		}

	}
}
