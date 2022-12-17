using nilnul.fs.address_.shield_;
using System;
using System.IO;

namespace nilnul.fs.folder.destinations
{

	public class _MoveX
	{
		public static void _Void_targetExist(string sourceParent_isFolder, string targetParent_exitsOrNot, StreamWriter log=null)
		{


			if (sourceParent_isFolder.Length >= 248)
			{
				log?.WriteLine("source too long:" + sourceParent_isFolder);

			}
			var source = new DirectoryInfo(sourceParent_isFolder);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();

			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(targetParent_exitsOrNot, file.Name);

				if (temppath.Length >= 260)
				{
					log?.WriteLine("target file address too long:" + temppath);

				}
				try
				{
					file.MoveTo(temppath);

				}
				catch (Exception e)
				{
					log?.WriteLine($"when copying {file.FullName}: {e}");
					throw;
				}


			}

			DirectoryInfo[] dirs = source.GetDirectories();


			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(targetParent_exitsOrNot, subdir.Name);
				_Void(subdir.FullName, temppath, log);
			}


		}
		public static void _Void(string sourceParent_isFolder, string targetParent_exitsOrNot, StreamWriter log=null)
		{
			if (!System.IO.Directory.Exists(targetParent_exitsOrNot))
			{
				if (nilnul.fs.address.be_.File.Singleton.be(targetParent_exitsOrNot))
				{
					throw new Exception($"{targetParent_exitsOrNot} is a file, not a folder.");
				}
				move_._TargetBlankX._assumeTargetParentNew(sourceParent_isFolder, targetParent_exitsOrNot, log);
			}
			else
			{
				_Void_targetExist(sourceParent_isFolder, targetParent_exitsOrNot, log);

			}


		}



		public static void _Void(BaseDir baseDir, string v, StreamWriter log=null)
		{
			_Void(baseDir.ToString(), v,log);
		}

		/// <summary>
		/// PathTooLongException]: The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.
		/// </summary>
		/// <param name="sourceParent"></param>
		/// <param name="targetParent"></param>
		/// <param name="copySubDirs"></param>

		public static void Void(Folder sourceParent, string targetParent, StreamWriter log=null)
		{

			_Void(sourceParent.en.ToString(), targetParent, log);


		}

		public static void Void(FolderI sourceParent, nilnul.fs.address_.ShieldI targetParent, StreamWriter log=null)
		{

			_Void(sourceParent.address.en.ToString(), targetParent.ToString(), log);


		}


		public static void Void(nilnul.fs.address_.ShieldI sourceParent, nilnul.fs.address_.ShieldI targetParent, StreamWriter log=null)
		{

			_Void(sourceParent.ToString(), targetParent.ToString(), log);


		}





	}
}
