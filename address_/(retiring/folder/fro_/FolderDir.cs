using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.folder.fro_
{
	public class FolderDir
	{
		static public Folder Eval(string folder, string dir) {
			return Eval(
				Folder.Parse(folder)
				,
				new _address.DirName(dir)
			);
		}

		static public Folder Eval(Folder folder, _address.DirName dir) {

			return new Folder(
				folder.root
				,
				new _address.Stem( folder.stem.dirs.Concat(new[] { dir})) 
				
			);
		}
	}
}
