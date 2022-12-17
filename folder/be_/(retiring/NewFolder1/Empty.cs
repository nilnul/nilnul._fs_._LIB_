using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// no dir nor doc
	/// </summary>
	///
	[Obsolete()]
	public class Empty
		:
		nilnul.fs.folder.BeA,
		nilnul.fs.folder.BeI
	{
		public override bool be(nilnul.fs.FolderI obj)
		{
			return nilnul.objs.be_._NoneX.None(
				System.IO.Directory.EnumerateFileSystemEntries(obj.ToString())
			);
			//throw new NotImplementedException();
		}

		public bool be(nilnul.fs.Folder obj)
		{
			return be((nilnul.fs.FolderI)obj);
			//throw new NotImplementedException();
		}

		public bool be(DirectoryInfo dirInfo)
		{
			return !dirInfo.EnumerateFileSystemInfos().Any();
			//throw new NotImplementedException();
		}

		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}

		//public  bool be_ofAddress(string selectedPath)
		//{
		//	return be(nilnul.fs.Folder.FroAddress(selectedPath));
		//	//throw new NotImplementedException();
		//}
	}
}
