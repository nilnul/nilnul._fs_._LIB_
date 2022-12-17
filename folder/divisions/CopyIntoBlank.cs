using System;
using System.IO;

namespace nilnul.fs.folder.andDestinations
{

	public class _CopyIntoBlankOrNewX
	{


		public static void CopyIntoBlankOrNew(string sourceFolder, string targetParent_blank, StreamWriter log)
		{
			if (!System.IO.Directory.Exists(targetParent_blank))
			{
				System.IO.Directory.CreateDirectory(targetParent_blank);
			}
			else
			{
				if (nilnul.fs.folder.be_.Dwelled.Singleton.be_ofAddress(targetParent_blank))
				{
					throw new Exception("target folder is not empty");
				}
			}
			_CopyIntoBlank_targetParentBlankExists(sourceFolder, targetParent_blank, log);
		}



		public static void _CopyIntoBlank_targetParentBlankExists(string sourceFolder, string _targetParent_blankExists, StreamWriter log)
		{



			if (sourceFolder.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceFolder);
				return;
			}

			var source = new DirectoryInfo(sourceFolder);
			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();

			if (_targetParent_blankExists.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_blankExists);
				return;
			}
			foreach (FileInfo file in files)
			{
				string temppath = Path.Combine(_targetParent_blankExists, file.Name);
				if (temppath.Length >= 260)
				{
					log.WriteLine("target file address too long:" + temppath);
				}
				else
				{
					file.CopyTo(temppath, false);
				}
			}

			DirectoryInfo[] dirs = source.GetDirectories();
			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(_targetParent_blankExists, subdir.Name);
				_CopyIntoBlank_target2bCreated(subdir.FullName, temppath, log);
			}
		}

		public static void _CopyIntoBlank_target2bCreated(string sourceFolder, string _targetParent_2bCreated, StreamWriter log)
		{


			if (_targetParent_2bCreated.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_2bCreated);
				return;

			}


			System.IO.Directory.CreateDirectory(_targetParent_2bCreated);


			if (sourceFolder.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceFolder);
				return;

			}
			var source = new DirectoryInfo(sourceFolder);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_2bCreated, file.Name);

				if (temppath.Length >= 260)
				{
					log.WriteLine("target file address too long:" + temppath);

				}
				else
				{
					file.CopyTo(temppath, false);

				}
			}

			DirectoryInfo[] dirs = source.GetDirectories();

			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(_targetParent_2bCreated, subdir.Name);
				_CopyIntoBlank_target2bCreated(subdir.FullName, temppath, log);
			}

		}

	}
}
