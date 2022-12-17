using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// no dir nor doc
	/// </summary>
	/// 
	[Obsolete()]
	public class Empty
		: BeI
	{
		public bool be(nilnul.fs.Folder obj)
		{
			return nilnul.objs.be_._NoneX.None(
				System.IO.Directory.EnumerateFileSystemEntries(obj.ToString())
			);
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
				return nilnul.obj.SingletonByDefault<Empty>.Instance;
			}
		}




		public static bool _Be(string selectedPath)
		{
			return Singleton.be(new Folder(selectedPath));

			//throw new NotImplementedException();
		}
	}
}
