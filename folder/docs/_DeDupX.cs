using System.IO;

namespace nilnul.fs.folder.docs
{

	static public class _DeDupX
	{
		static public void Vod(
			nilnul.fs.Folder folder
			,
			StreamWriter log
		)
		{
			nilnul.fs.files._DelDupX._Void(nilnul.fs.folder._DocsX.Files(folder), log);


		}

		static public void Vod(
			string folder
			,
			StreamWriter log

		)
		{
			Vod(
				nilnul.fs.Folder.FroAddress(folder), log
			);
		}

		static public string Log_ofAddress(
			string folder


		)
		{
			string r;
			using (var log = nilnul.fs.folder_.tmp._CreateLogX.CreateLogTimed("deDup", out r))
			{
				Vod(
					nilnul.fs.Folder.FroAddress(folder), log
				);

			}
			return r;
		}


	}
}
