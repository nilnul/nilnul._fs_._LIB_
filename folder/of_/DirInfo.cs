using System;
using System.IO;

namespace nilnul.fs.folder.of_
{

	public class DirInfo : OfI<DirectoryInfo>
	{
		public FolderI of(DirectoryInfo arg)
		{
			return (nilnul.fs.Folder)(arg);
			throw new NotImplementedException();
		}


		static public DirInfo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DirInfo>.Instance;
			}
		}

	}
}
