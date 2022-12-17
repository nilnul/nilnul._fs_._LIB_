using System;
using System.IO;

namespace nilnul.fs.folder.destinations
{

	public class _DuplicateX
	{
		/// <summary>
		/// PathTooLongException]: The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.
		/// </summary>
		/// <param name="sourceParent"></param>
		/// <param name="targetParent"></param>
		/// <param name="copySubDirs"></param>
		public static void Duplicate(string sourceParent, string targetParent, bool copySubDirs, StreamWriter log


			)
		{


			if (targetParent.Length >= 248)
			{
				log.WriteLine("target too long:" + targetParent);
				return;

			}


			if (!System.IO.Directory.Exists(targetParent))
			{
				System.IO.Directory.CreateDirectory(targetParent);
			}
			else
			{
				if (nilnul.fs.folder.be_.Dwelled.Singleton.be_ofAddress(targetParent))
				{
					throw new Exception("target folder is not empty");

				}
			}
			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(targetParent, file.Name);

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

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(targetParent, subdir.Name);
					Duplicate(subdir.FullName, temppath, copySubDirs, log);
				}
			}

		}

		internal static void Duplicate(Folder sourceParent, string targetParent, StreamWriter log)
		{

			if (targetParent.Length >= 248)
			{
				log.WriteLine("target too long:" + targetParent);
				return;

			}


			if (!System.IO.Directory.Exists(targetParent))
			{
				System.IO.Directory.CreateDirectory(targetParent);
			}

			if (sourceParent.ToString().Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = (DirectoryInfo)(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(targetParent, file.Name);

				if (temppath.Length >= 260)
				{
					log.WriteLine("target file address too long:" + temppath);

				}
				else
				{
					try
					{
						file.CopyTo(temppath, false);

					}
					catch (Exception e)
					{
						log.WriteLine($"when copying {file.FullName}: {e}");
					}

				}

			}

			DirectoryInfo[] dirs = source.GetDirectories();


			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(targetParent, subdir.Name);
				Duplicate(subdir.FullName, temppath, log);
			}


		}

		public static void Duplicate(string sourceParent, string targetParent, StreamWriter log)
		{


			if (targetParent.Length >= 248)
			{
				log.WriteLine("target too long:" + targetParent);
				return;

			}


			if (!System.IO.Directory.Exists(targetParent))
			{
				System.IO.Directory.CreateDirectory(targetParent);
			}

			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(targetParent, file.Name);

				if (temppath.Length >= 260)
				{
					log.WriteLine("target file address too long:" + temppath);

				}
				else
				{
					try
					{
						file.CopyTo(temppath, false);

					}
					catch (Exception e)
					{
						log.WriteLine($"when copying {file.FullName}: {e}");
					}

				}

			}

			DirectoryInfo[] dirs = source.GetDirectories();


			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(targetParent, subdir.Name);
				Duplicate(subdir.FullName, temppath, log);
			}


		}

		public static void _Duplicate_targetParentExistsBlank(string sourceParent, string _targetParent_existsBlank, StreamWriter log)
		{


			if (_targetParent_existsBlank.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_existsBlank);
				return;

			}


			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_existsBlank, file.Name);

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
				string temppath = Path.Combine(_targetParent_existsBlank, subdir.Name);
				_Duplicate_targetParentNew(subdir.FullName, temppath, log);
			}


		}
		public static void _Duplicate_targetParentNew(string sourceParent, string _targetParent_new, StreamWriter log)
		{


			if (_targetParent_new.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_new);
				return;

			}

			System.IO.Directory.CreateDirectory(_targetParent_new);


			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}

			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_new, file.Name);

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
				string temppath = Path.Combine(_targetParent_new, subdir.Name);
				_Duplicate_targetParentNew(subdir.FullName, temppath, log);
			}


		}

		public static void _Duplicate_targetParentExists_vowEmpty(string sourceParent, string _targetParent_exists, StreamWriter log)
		{


			if (_targetParent_exists.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_exists);
				return;

			}



			if (nilnul.fs.folder.be_.Dwelled.Singleton.be_ofAddress(_targetParent_exists))
			{
				throw new Exception("target folder is not empty");

			}

			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_exists, file.Name);

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
				string temppath = Path.Combine(_targetParent_exists, subdir.Name);
				_Duplicate_targetParentNew(subdir.FullName, temppath, log);
			}


		}

		public static void _Duplicate_targetParentExists(string sourceParent, string _targetParent_exists, StreamWriter log)
		{


			if (_targetParent_exists.Length >= 248)
			{
				log.WriteLine("target too long:" + _targetParent_exists);
				return;

			}


			if (sourceParent.Length >= 248)
			{
				log.WriteLine("source too long:" + sourceParent);
				return;

			}
			var source = new DirectoryInfo(sourceParent);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo file in files)
			{

				string temppath = Path.Combine(_targetParent_exists, file.Name);

				if (temppath.Length >= 260)
				{
					log.WriteLine("target file address too long:" + temppath);

				}
				else
				{
					try
					{
						file.CopyTo(temppath, false);

					}
					catch (Exception e)
					{
						log.WriteLine($"when copying {file.FullName}:{e}");
					}

				}

			}

			DirectoryInfo[] dirs = source.GetDirectories();


			foreach (DirectoryInfo subdir in dirs)
			{
				string temppath = Path.Combine(_targetParent_exists, subdir.Name);
				Duplicate(subdir.FullName, temppath, log);
			}


		}

		//[Obsolete("winApi needed", true)]
		//public static void _Duplicate_overlongPrefixed(string sourceParent_overlong, string targetParent_overlong, bool copySubDirs = true)
		//{


		//	if (!Directory.Exists(targetParent_overlong))
		//	{
		//		Directory.CreateDirectory(targetParent_overlong);
		//	}
		//	else
		//	{
		//		if (nilnul.fs.folder.be_.Dwelled.Singleton.be(targetParent_overlong))
		//		{
		//			throw new Exception("target folder is not empty");

		//		}
		//	}

		//	var source = new DirectoryInfo(sourceParent_overlong);

		//	// Get the files in the directory and copy them to the new location.
		//	FileInfo[] files = source.GetFiles();
		//	foreach (FileInfo file in files)
		//	{
		//		string temppath = Path.Combine(targetParent_overlong, file.Name);
		//		file.CopyTo(temppath, false);
		//	}

		//	DirectoryInfo[] dirs = source.GetDirectories();

		//	// If copying subdirectories, copy them and their contents to new location.
		//	if (copySubDirs)
		//	{
		//		foreach (DirectoryInfo subdir in dirs)
		//		{
		//			string temppath = Path.Combine(targetParent_overlong, subdir.Name);
		//			_Duplicate_overlongPrefixed(subdir.FullName, temppath, copySubDirs);
		//		}
		//	}

		//}

		//[Obsolete("winApi needed", true)]

		//public static void Duplicate_prefixIntoOverlong(string sourceParent, string targetParent, bool copySubDirs = true)
		//{
		//	_Duplicate_overlongPrefixed(
		//		nilnul.fs.address._OverlongX.Prepend(sourceParent)
		//		,
		//		nilnul.fs.address._OverlongX.Prepend(targetParent)
		//		,
		//		copySubDirs
		//	);
		//}

		//[Obsolete("winApi needed", true)]

		//public static void Duplicate(nilnul.fs.Folder sourceParent, string targetParent, bool copySubDirs = true)
		//{

		//	Duplicate(sourceParent.ToString(), targetParent, copySubDirs);
		//}

	}
}
