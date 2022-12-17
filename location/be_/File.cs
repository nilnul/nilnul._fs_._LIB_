using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._location_;

namespace nilnul.fs.location.be_
{
	public class File : 
		nilnul.fs.location.BeA
		,
		nilnul.fs.location.BeI
	{
		

		public override bool be(BlankI obj)
		{
			return nilnul.fs.location_.file0Folder.be_.File.Singleton.be(
				nilnul.fs.location_.File0FolderA.Parse(obj)
			);

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
