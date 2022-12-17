using Microsoft.VisualBasic.FileIO;

namespace nilnul.fs.file.del_
{
	static public class _RecyclableX
	{
		public static void Del(
			string file

		)
		{
			Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
		}
		public static void Del(
			FileI file
		)
		{
			Del(file.file.en.ToString());
		}





	}
}
