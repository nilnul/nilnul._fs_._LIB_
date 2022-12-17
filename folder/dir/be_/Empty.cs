using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.folder.dir.be_
{
	static public class _EmptyX
	{
	
		public static bool Be(nilnul.fs.folder_.ParentDir parentDir)
		{
			return nilnul.fs.folder.be_.Empty.Singleton.be(parentDir);
		}

		public static bool Be(FolderI parent, DirI dir)
		{
			return Be(
				new nilnul.fs.folder_.ParentDir(parent,dir)
				);
		}


		
	}
}
