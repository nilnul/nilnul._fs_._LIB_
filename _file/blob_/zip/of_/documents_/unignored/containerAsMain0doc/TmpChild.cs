using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip.of_.documents_.unignored.containerAsMain0doc
{
	static public class _TmpChildX
	{
		public static nilnul.fs.address_.spear_.ParentDoc ParentDoc_ofAddress(
			 string folder
		)
		{
			return ParentDoc(
				nilnul.fs.Folder.FroAddress(folder)
			); ;

		}
		public static nilnul.fs.address_.spear_.ParentDoc ParentDoc(
			 nilnul.fs.FolderI folder
		)
		{
			//var doc = _FolderNomAsMain0docX.DocAsDotted(folder.address.en);
			var tgtContainer = nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofVered(
				nameof(_TmpChildX)
			);

			var doc= _FolderNomAsMain0docX.DocAsExted(
				folder
				,
				tgtContainer
			);

			return new fs.address_.spear_.ParentDoc(
				tgtContainer.address.en
				,
				doc
			);

		}



	}
}
