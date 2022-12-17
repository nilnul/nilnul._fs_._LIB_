using System.IO;
using System.Linq;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// no dir nor doc
	/// </summary>
	public class Empty1
		:
		nilnul.fs.folder.BeA1,
		nilnul.fs.folder.BeI1
	{
		public override bool be(nilnul.fs.FolderI1 obj)
		{
			return nilnul.objs.be_._NoneX.None(
				System.IO.Directory.EnumerateFileSystemEntries(obj.ToString())
			);
			//throw new NotImplementedException();
		}

		public bool be(nilnul.fs.Folder1 obj)
		{
			return be((nilnul.fs.FolderI1)obj);
			//throw new NotImplementedException();
		}

		public bool be(DirectoryInfo dirInfo)
		{
			return !dirInfo.EnumerateFileSystemInfos().Any();
			//throw new NotImplementedException();
		}


		static public Empty1 Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Empty1>.Instance;
			}
		}
		static public Empty1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Empty1>.Instance;
			}
		}


	}
}
