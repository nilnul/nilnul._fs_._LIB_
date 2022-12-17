using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_.file0Folder
{
	/// <summary>
	/// sele
	/// </summary>
	static public class _ExploreX
	{
		static public void Sel(File0FolderI file0Folder) {
			switch (file0Folder)
			{
				case FileI file:
					 nilnul.fs.file.explore_._SelX.Vod(file);
					break;
				case FolderI folder:
					 nilnul.fs.folder.explore_._ByExeSelfX.Exe(folder);
					break;
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}
		static public void Sel(string file0Folder) {
			Sel(
				File0FolderA.Parse(file0Folder)
			); ;
		}

	}
}
