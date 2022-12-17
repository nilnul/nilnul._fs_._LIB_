using nilnul.fs.address_.shield_;
using System;
using System.IO;

namespace nilnul.fs.folder.destinations.move_
{

	static public class TgtUnoccopiedX
	{

		public static void _assumeSrcIsFolder(string sourceParent_isFolder, string targetParent_exitsOrNot)
		{
			nilnul.fs.folder._CreateX._Void_ofAddress(targetParent_exitsOrNot);

			move_._TargetBlankX._assumeTargetParentNew(sourceParent_isFolder, targetParent_exitsOrNot);



		}



		public static void _Vod_assumeSrcIsFolder(BaseDir baseDir, string v)
		{
			_assumeSrcIsFolder(baseDir.ToString(), v);
		}

		/// <summary>
		/// PathTooLongException]: The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.
		/// </summary>
		/// <param name="sourceParent"></param>
		/// <param name="targetParent"></param>
		/// <param name="copySubDirs"></param>

		public static void Void(Folder sourceParent, string targetParent)
		{
			_assumeSrcIsFolder(sourceParent.en.ToString(), targetParent);
		}

		public static void Void(FolderI sourceParent, string targetParent)
		{
			_assumeSrcIsFolder(sourceParent.address.en.ToString(), targetParent);
		}

		public static void Void(FolderI sourceParent, nilnul.fs.address_.ShieldI targetParent)
		{
			_assumeSrcIsFolder(sourceParent.address.en.ToString(), targetParent.ToString());
		}



	}
}
