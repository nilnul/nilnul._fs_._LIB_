using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_.file0Folder.be_
{
	public class File : nilnul.fs.location_.file0Folder.BeI
	{
		public bool be(File0FolderI obj)
		{
			return obj is nilnul.fs.FileI;
			//throw new NotImplementedException();
		}

		static public File Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<File>.Instance;
			}
		}

	}
}
