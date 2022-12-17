using System;
using System.IO;

namespace nilnul.fs.folder.to_
{
	static public class _InfoX1
	{
		static public DirectoryInfo To(this FolderI1 src)
		{
			return new DirectoryInfo(src.address.ee.ToString());
		}

	
	}

	public class Info1 : op_.ToI<DirectoryInfo>
	{
		public DirectoryInfo op(FolderI1 src)
		{
			return _InfoX1.To(src);
			//throw new NotImplementedException();
		}

		

		static public Info1 Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Info1>.Instance;
			}
		}
		static public Info1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Info1>.Instance;
			}
		}



	}
}
