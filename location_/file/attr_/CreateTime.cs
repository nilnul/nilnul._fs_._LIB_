using System;
using System.IO;

namespace nilnul.fs.location_.file.attr_
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
	}
}
