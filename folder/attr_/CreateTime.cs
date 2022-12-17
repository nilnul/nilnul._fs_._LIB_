using System;
using System.IO;

namespace nilnul.fs.location_.folder.attr_
{
	public class CreateTime
	{
		static public void ChangeCreateTime(string _location, DateTime time)
		{
			System.IO.Directory.SetCreationTime(_location, time);


		}

		public static void Set(DirectoryInfo _location, DateTime time)
		{
			System.IO.Directory.SetCreationTime(_location.FullName, time);
		}
	}
}
