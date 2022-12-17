using System;
using System.IO;

namespace nilnul.fs.folder.op_.to_
{
	static public class _InfoX
	{
		static public DirectoryInfo To(this FolderI1 src)
		{
			return new DirectoryInfo(src.address.ee.ToString());
		}

	
	}

	public class Info : ToI<DirectoryInfo>
	{
		public DirectoryInfo op(FolderI1 src)
		{
			return _InfoX.To(src);
			//throw new NotImplementedException();
		}

		

		static public Info Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Info>.Instance;
			}
		}
		static public Info Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Info>.Instance;
			}
		}



	}
}
