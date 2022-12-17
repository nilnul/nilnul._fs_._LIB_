using System;
using System.IO;

namespace nilnul.fs.file.attr_
{
	public class CreateTime
	{
		static public void ChangeCreateTime(string _location, DateTime time)
		{
			System.IO.File.SetCreationTime(_location, time);


		}

		public static void ChangeCreateTime(FileInfo doc, DateTime time)
		{
			System.IO.File.SetCreationTime(doc.FullName, time);

		}
		public static DateTime Get(FileInfo doc)
		{
			return System.IO.File.GetCreationTime(doc.FullName);

		}

		public static DateTime Get(string doc)
		{
			return System.IO.File.GetCreationTime(doc);

		}


	}
}
