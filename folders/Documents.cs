using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folders
{
	static public class _DocumentsX
	{
		static public IEnumerable<FileInfo> Infos(IEnumerable<DirectoryInfo> folderInfo)
		{
			return folderInfo.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos(x)
			);
		}

		static public IEnumerable<FileInfo> Infos_ofAddresses(IEnumerable<string> folderInfo)
		{
			return folderInfo.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos_ofAddress(x)
			);
		}

		static public IEnumerable<FileInfo> Infos_ofAddresses(params string[] folderInfo)
		{
			return Infos_ofAddresses((IEnumerable<string>)folderInfo);
		}

		static public IEnumerable<nilnul.fs.File> Files(IEnumerable<nilnul.fs.Folder> folderInfo)
		{
			return folderInfo.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos(x)
			).Select(x => new nilnul.fs.File(x.FullName));
		}


		/// <summary>
		/// todo:
		/// </summary>
		/// <param name="folders"></param>
		/// <returns></returns>
		/// 
		static public IEnumerable<nilnul.fs.File> Files_ofAddresses(

			params string[] folders

		)
		{
			return Files(
				folders.Select(x => nilnul.fs.Folder.FroAddress(x))
			);

		}





	}
}
