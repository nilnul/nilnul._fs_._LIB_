using System;
using System.IO;

namespace nilnul.fs.file.to_
{
	public class ToFileInfo : ToI<FileInfo>
	{
		public FileInfo to(FileI src)
		{
			return new FileInfo(src.file.en.ToString());
		}
		public FileInfo to(FileI1 file)
		{
			return new FileInfo(file.file.ee.ToString());
		}


		static public ToFileInfo Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ToFileInfo>.Instance;
			}
		}

	}
}
