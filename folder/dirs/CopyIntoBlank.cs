using System;
using System.Collections.Generic;
using System.IO;

namespace nilnul.fs.folder.dirs
{
	public static class _CopyIntoBlankOrNewDirsX
	{
		static public void CopyIntoBlankOrNew(nilnul.fs.Folder sourceParent, IEnumerable<string> dirs, string _targetParent_blankOrNew, StreamWriter log)
		{

			System.IO.Directory.CreateDirectory(_targetParent_blankOrNew);

			dirs.ForEach(
				x => nilnul.fs.folder.dir._CopyIntoX._CopyInto_targetParenExists(

					sourceParent,

					x

					,
					_targetParent_blankOrNew
					,
					log
				)
			);
		}

		public static void CopyIntoBlankOrNew(string folder, string[] dirs, Folder subFolder, StreamWriter log)
		{
			CopyIntoBlankOrNew(nilnul.fs.Folder.FroAddress(folder), dirs, subFolder.ToString(),log);
		}
	}
}