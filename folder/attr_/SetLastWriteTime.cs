using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.location_.folder
{
	[Obsolete(nameof(attr_.WriteTime))]
	public class SetLastWriteTime
	{

		static public void _Exec(string _location, TextWriter log)
		{
			///

			//if (!Directory.Exists(path))
			//{
			//	return;
			//}

			///

			DirectoryInfo location = new DirectoryInfo(_location);


			Exec_depthFirst(location, log);

		}



		static public void Exec_depthFirst(DirectoryInfo _location, TextWriter log)
		{

			DirectoryInfo[] dirs = new DirectoryInfo[0];
			try
			{
				dirs = _location.GetDirectories();

			}
			catch (Exception e)
			{
				log.WriteLine(string.Format("Error in getting subdirs of {0}", _location.FullName) + ":" + e.Message);
			}

			foreach (var item in dirs)
			{
				Exec_depthFirst(item, log);
			}

			try
			{

				var dstS = _location.GetFileSystemInfos();
				if (dstS.Any())
				{
					var subDirsTime = dstS.Select(fs => fs.LastWriteTime).OrderByDescending(x => x).First();

					if (subDirsTime > _location.LastWriteTime)
					{
						_location.LastWriteTime = subDirsTime;
					}

				}


			}
			catch (Exception e2)
			{
				log.WriteLine("Error in updating last time of " + _location.ToString() + ":" + e2.Message);


			}




		}
	}
}
