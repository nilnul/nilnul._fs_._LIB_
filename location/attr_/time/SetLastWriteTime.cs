using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.win.setLastModifyTime
{
	public class SetLastWriteTime
	{
		static public void SetLastModifyTime__sln(TextWriter sw)
		{
			var path = @"D:\wyt\360yun\work130918\sln";
			Exec(path, sw);


		}


		static public void SetLastModifyTime__temp(TextWriter sw)
		{
			var path = @"D:\temp";
			Exec(path, sw);


		}



		static public void Exec(string path, TextWriter sw)
		{
			///

			if (!Directory.Exists(path))
			{
				return;


			}

			///

			DirectoryInfo d = new DirectoryInfo(path);


			Exec(d, sw);

		}



		static public void Exec(DirectoryInfo d, TextWriter log)
		{

			DirectoryInfo[] dirs = new DirectoryInfo[0];
			try
			{



				dirs = d.GetDirectories();



			}
			catch (Exception e)
			{

				log.WriteLine(string.Format("Error in getting subdirs of {0}", d.FullName) + ":" +e.Message);


			}

			foreach (var item in dirs)
			{
				Exec(item, log);

			}


			try
			{


				var fsS = d.GetFileSystemInfos();
				if (fsS.Any())
				{
					var subDirsTime = fsS.Select(fs => fs.LastWriteTime).OrderByDescending(x => x).First();
					if (subDirsTime > d.LastWriteTime)
					{
						d.LastWriteTime = subDirsTime;

					}

				}


			}
			catch (Exception e2)
			{
				log.WriteLine("Error in updating last time of " + d.ToString() + ":" + e2.Message);
				

			}




		}
	}
}
