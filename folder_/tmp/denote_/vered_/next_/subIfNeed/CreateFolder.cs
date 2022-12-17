using System.IO;

namespace nilnul.fs.folder_.tmp.denote_.ver_.next_.subIfNeed
{
	static public class _CreateFolderX
	{
		static public DirectoryInfo Info(string prefix)
		{
			return nilnul.fs.folder.denote_.vered_.next_.subIfNeed._CreateFolderX.Info(
				nilnul.fs.folder_._TmpX.Get()
				,
				prefix
			);
		}

		/// <summary>
		/// the main may bring ver
		/// </summary>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.fs.Folder Folder(string prefix)
		{
			return new nilnul.fs.Folder(
				Info(
					prefix
				)
			);
		}

	}
}
