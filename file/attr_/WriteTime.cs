using System;
using System.IO;

namespace nilnul.fs.file.attr_
{
	public class WriteTime
	{
		static public void SetLastModifyTime(string _location, DateTime time)
		{
			System.IO.File.SetLastWriteTime(_location, time);
		}

		public static void SetLastWriteTime(FileInfo _location, DateTime time)
		{

			System.IO.File.SetLastWriteTime(_location.FullName, time);


		}
	}
}
