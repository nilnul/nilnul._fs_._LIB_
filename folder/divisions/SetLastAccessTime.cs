using System;
using System.IO;

namespace nilnul.fs.location_.folder.andDestinations
{
	public class SetLastAccessTime
	{

		static public void _Exec(string _location, DateTime time)
		{
			///

			//if (!Directory.Exists(path))
			//{
			//	return;
			//}

			///

			DirectoryInfo location = new DirectoryInfo(_location);


			Exec_depthFirst(location, time);

		}

		static public void Exec_depthFirst(DirectoryInfo _location, DateTime time)
		{
			DirectoryInfo[] dirs = new DirectoryInfo[0];
			try
			{
				dirs = _location.GetDirectories();

			}
#pragma warning disable CS0168 // The variable 'e' is declared but never used
			catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{
				throw;
			}

			foreach (var item in dirs)
			{
				Exec_depthFirst(item, time);
			}
			foreach (var doc in _location.GetFiles())
			{
				location_.file.attr_.AccessTime.SetLastAccessTime(doc, time);
			}

			location_.folder.attr_.AccessTime.Set(_location, time);


		}
	}
}
