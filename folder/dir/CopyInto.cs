using System.IO;

namespace nilnul.fs.folder.dir
{

	public class _CopyIntoX
	{


		public static void CopyIntoExistsOrNew(string sourceFolder, string targetParent_blank, StreamWriter log)
		{
			System.IO.Directory.CreateDirectory(targetParent_blank);

			_CopyInto_targetParenExists(sourceFolder, targetParent_blank, log);
		}



		public static void _CopyInto_targetParenExists(string sourceFolderDir, string _targetParent_Exists, StreamWriter log)
		{
			_CopyInto_targetParenExists(
				 nilnul.fs.address_.Shield.FroAddress(sourceFolderDir), _targetParent_Exists, log
			);
		}



		public static void _CopyInto_targetParenExists(nilnul.fs.address_.Shield sourceFolderDir, string _targetParent_Exists, StreamWriter log)
		{

			nilnul.fs.folder.destinations._DuplicateX.Duplicate(
				sourceFolderDir.ToString(),
				System.IO.Path.Combine(_targetParent_Exists, nilnul.fs.address_.shield_.BaseDir._Ov(sourceFolderDir).child.ToString())
				, log
			);
		}


		public static void _CopyInto_targetParenExists(nilnul.fs.address_.ShieldI dirParent, string dir, string _targetParent_Exists, StreamWriter log)
		{

			nilnul.fs.folder.destinations._DuplicateX._Duplicate_targetParentExists(
				dirParent.ToString(),
				System.IO.Path.Combine(_targetParent_Exists, dir)
				, log
			);
		}


		public static void _CopyInto_targetParenExists(nilnul.fs.Folder folder, string dir, string _targetParent_Exists, StreamWriter log)
		{
			var target = System.IO.Path.Combine(_targetParent_Exists, dir);

			System.IO.Directory.CreateDirectory(
				target
			);


			nilnul.fs.folder.destinations._DuplicateX.Duplicate(
				nilnul.fs.folder.dir._CreateX.Folder_ofDirName(folder, dir)
				,
				target
				, log
			);
		}

		public static void _CopyInto_target2bCreated(string sourceFolder, string _targetParent_2bCreated, StreamWriter log)
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
				_CopyInto_target2bCreated(subdir.FullName, temppath, log);
			}

		}

	}
}
