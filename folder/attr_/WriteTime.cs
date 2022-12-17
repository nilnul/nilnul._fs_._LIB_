using System;
using System.IO;

namespace nilnul.fs.location_.folder.attr_
{
	public class WriteTime
	{
		static public void SetLastModifyTime(string _location, DateTime time)
		{
			System.IO.Directory.SetLastWriteTime(_location, time);
		}
		public static void Set(DirectoryInfo _location, DateTime time)
		{
			System.IO.Directory.SetLastWriteTime(_location.FullName, time);
		}


	}
}
