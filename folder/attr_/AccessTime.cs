using System;
using System.IO;

namespace nilnul.fs.location_.folder.attr_
{
	public class AccessTime
	{
		static public void SetLastAccessTime(string _location, DateTime time)
		{
			System.IO.Directory.SetLastAccessTime(_location, time);
		}

		public static void Set(DirectoryInfo _location, DateTime time)
		{
			System.IO.Directory.SetLastAccessTime(_location.FullName, time);
		}



	}
}
