using System;
using System.IO;

namespace nilnul.fs.folder.to_
{
	[Obsolete()]
	static public class _InfoX
	{
		static public DirectoryInfo To(this FolderI src)
		{
			return new DirectoryInfo(src.address.en.ToString());
		}
	}

	[Obsolete()]
	public class Info : ToI<DirectoryInfo>
	{
		public DirectoryInfo to(FolderI src)
		{
			return _InfoX.To(src);
			//throw new NotImplementedException();
		}




		static public Info Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Info>.Instance;
			}
		}

	}
}
