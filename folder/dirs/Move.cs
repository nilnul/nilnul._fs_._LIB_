using System;
using System.Collections.Generic;
using System.IO;

namespace nilnul.fs.folder.dirs
{
	public static class _MoveX
	{
		static public void _assumeTargetParentBlankOrNew(nilnul.fs.Folder sourceParent, IEnumerable<string> dirs, string _targetParent_blankOrNew, StreamWriter log)
		{

			//System.IO.Directory.CreateDirectory(_targetParent_blankOrNew);

			dirs.ForEach(
				x => nilnul.fs.folder.dir._MoveX._assumeTagetParentNew0Blank(

					sourceParent,

					x

					,
					_targetParent_blankOrNew
					,
					log
				)
			);
		}
		public static void _assumeTargetParentBlankOrNew(string folder, IEnumerable<string> dirs, FolderI subFolder, StreamWriter log)
		{

			_assumeTargetParentBlankOrNew(  nilnul.fs.Folder.FroAddress(folder),dirs, subFolder.ToString(),log);
		}

		static public void _Vod(nilnul.fs.Folder sourceParent, IEnumerable<string> dirs, string _targetParent_blankOrNew, StreamWriter log)
		{

			//System.IO.Directory.CreateDirectory(_targetParent_blankOrNew);

			dirs.ForEach(
				x => nilnul.fs.folder.dir._MoveX._Void(

					sourceParent,

					x

					,
					_targetParent_blankOrNew
					,
					log
				)
			);
		}

		static public void _Vod_assumeTgtDirUnoccupied(nilnul.fs.FolderI sourceParent, IEnumerable<fs._address.DirI> dirs, nilnul.fs.FolderI _targetParent_noSameDir)
		{

			//System.IO.Directory.CreateDirectory(_targetParent_blankOrNew);

			dirs.ForEach(
				x => nilnul.fs.folder.dir._MoveX._Vod(

					sourceParent,

					x

					,
					_targetParent_noSameDir
					
				)
			);
		}



		public static void _Vod(string folder, IEnumerable<string> dirs, FolderI subFolder, StreamWriter log)
		{

			_Vod(  nilnul.fs.Folder.FroAddress(folder),dirs, subFolder.ToString(),log);
		}

		public static void _Vod_tgtOfAddressAssumeDirsUnoccupied(
			nilnul.fs.address_.ShieldI folder
			,
			IEnumerable<_address.DirI> dirs
			,
			string subFolder)
		{

			_Vod_assumeTgtDirUnoccupied( new  nilnul.fs.Folder(folder),dirs, nilnul.fs.Folder.FroAddress(subFolder));
		}

	}
}