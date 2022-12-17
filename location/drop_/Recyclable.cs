using Microsoft.VisualBasic.FileIO;

namespace nilnul.fs.location.drop_
{
	static public class _RecyclableX
	{
		
		public static void Del(
			File0FolderI location
		)
		{

			if (location is nilnul.fs.FileI file)
			{
				nilnul.fs.file.del_._RecyclableX.Del(file);

			}
			nilnul.fs.folder.drop_._RecyclableX.Drop( (nilnul.fs.FolderI)location);
		}





	}
}
