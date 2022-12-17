using System.IO;

namespace nilnul.fs.folder.divs_.noDocuments
{
	static public class _DelX
	{


		static public void ByRecur(DirectoryInfo directoryInfo)
		{

			///delete sub forlders
			foreach (var dirInfo in nilnul.fs.folder._DirsX.Infos(directoryInfo))
			{
				ByRecur(dirInfo);
			}

			if (nilnul.fs.folder.be_.Empty.Singleton.be(directoryInfo))
			{
				directoryInfo.Delete();
			}
		}
		static public void ByRecur(string folder)
		{
			ByRecur(
				new DirectoryInfo(folder)
			);
		}


		/// <summary>
		/// delete folders that contain no documents
		/// </summary>
		static public void ByRecur(nilnul.fs.Folder folder)
		{
			ByRecur(
				(DirectoryInfo)folder
			);
		}





	}
}
