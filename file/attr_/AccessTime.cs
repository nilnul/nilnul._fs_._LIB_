using System;
using System.IO;

namespace nilnul.fs.file.attr_
{
	public class AccessTime
	{
		static public void SetLastAccessTime(string _location, DateTime time)
		{
			System.IO.File.SetLastAccessTime(_location, time);
		}

		public static void SetLastAccessTime(FileInfo _locationOfFile, DateTime time)
		{
			System.IO.File.SetLastAccessTime(_locationOfFile.FullName, time);

		}
	}
}
