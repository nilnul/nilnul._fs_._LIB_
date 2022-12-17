using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folders.documents_
{
	public class FileInfoS
	{
		static public IEnumerable<FileInfo> Enumerate(IEnumerable<DirectoryInfo> folderInfo)
		{
			return folderInfo.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos(x)
			);
		}

		static public IEnumerable<nilnul.fs.File> Enumerate_retFiles(IEnumerable<nilnul.fs.Folder> folderInfo)
		{
			return folderInfo.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos(x)
			).Select(x => new nilnul.fs.File(x.FullName));
		}


		static public IEnumerable<string> Enumerate_retTxts(

			params string[] folders

		)
		{
			return folders.SelectMany(
				x => nilnul.fs.folder._DocumentsX.Infos_ofAddress(x).Select(y => y.FullName)
			);

		}

		static public IEnumerable<FileInfo> Enumerate(

			params string[] folders

		)
		{
			return Enumerate_retTxts(folders).Select(
				x => new FileInfo(x)
			);

		}

	}
}
