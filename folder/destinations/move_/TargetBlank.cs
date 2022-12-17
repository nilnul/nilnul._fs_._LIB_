using nilnul.fs.address_.shield_;
using System;
using System.IO;

namespace nilnul.fs.folder.destinations.move_
{

	public class _TargetBlankX
	{
		public static void _assumeTargetParentExist(string sourceParent, string _targetParent_existsBlank, StreamWriter log=null)
		{

			//if (_targetParent_existsBlank.Length >= 248)
			//{
			//	log.WriteLine("target too long:" + _targetParent_existsBlank);

			//}


			//if (sourceParent.Length >= 248)
			//{
			//	log.WriteLine("source too long:" + sourceParent);

			//}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_existsBlank, file.Name);

				if (temppath.Length >= 260)
				{
					log?.WriteLine("target file address too long:" + temppath);

				}
				
				file.MoveTo(temppath);

				

			}

			DirectoryInfo[] dirs = source.GetDirectories();


			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(_targetParent_existsBlank, subdir.Name);
				_assumeTargetParentNew(subdir.FullName, temppath, log);
			}


		}
		public static void _Void(string sourceParent_isFolder, string targetParent_exitsOrNot, StreamWriter log=null)
		{
			if (!System.IO.Directory.Exists(targetParent_exitsOrNot))
			{
				System.IO.Directory.CreateDirectory(targetParent_exitsOrNot);
			}

			_assumeTargetParentExist(sourceParent_isFolder, targetParent_exitsOrNot, log);


		}

		internal static void _Void(BaseDir src, string target, StreamWriter log)
		{
			_Void(src.ToString(),target,log);
		}

		/// <summary>
		/// PathTooLongException]: The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.
		/// </summary>
		/// <param name="sourceParent"></param>
		/// <param name="targetParent"></param>
		/// <param name="copySubDirs"></param>

		internal static void Void(Folder sourceParent, string targetParent, StreamWriter log=null)
		{

			_Void(sourceParent.en.ToString(), targetParent, log);


		}


		public static void _assumeTargetParentNew(string sourceParent, string _targetParent_new, StreamWriter log=null)
		{


			//if (_targetParent_new.Length >= 248)
			//{
			//	log.WriteLine("target too long:" + _targetParent_new);
			//	return;

			//}

			System.IO.Directory.CreateDirectory(_targetParent_new);


			//if (sourceParent.Length >= 248)
			//{
			//	log.WriteLine("source too long:" + sourceParent);
			//	return;

			//}

			_assumeTargetParentExist(sourceParent, _targetParent_new, log);


		}

		public static void _targetParentExist_vowEmpty(string sourceParent, string _targetParent_exists, StreamWriter log=null)
		{
			if (nilnul.fs.folder.be_.Dwelled.Singleton.be_ofAddress(_targetParent_exists))
			{
				throw new Exception("target folder is not empty");
			}
			_assumeTargetParentExist(sourceParent, _targetParent_exists, log);
		}
	}
}
