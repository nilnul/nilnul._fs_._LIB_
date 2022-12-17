using nilnul.fs._address;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dsts_
{
	/// <summary>
	/// excluding ingored per doc as well per convention
	/// </summary>
	static public class _ConsideredX
	{
		public static IEnumerable<nilnul.fs._address._route.division_._div.DstI> Dsts(
			nilnul.fs.FolderI1 folder
			,
			nilnul.fs._address._route.division_._div._dir.DntI  doc =null
		)
		{
			return dsts_._UnignoredX.Dsts(folder, doc).Where(
				d => !(
					d.caption.en.Contains("(~)")
					|| d.caption.en.StartsWith("~)")
					|| d.caption.en.EndsWith("(~")
					|| d.caption.en.StartsWith(".")		//such as ".git"
				)
			);
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div.DstI> Dsts(
			nilnul.fs.Folder1 folder, nilnul.fs._address._route.division_._div._dir.DntI  doc = null)
		{
			return Dsts((FolderI1)folder, doc);
		}

		static public IEnumerable<nilnul.fs._address._route.division_._div.DstI> Dsts(
			DirectoryInfo folder, nilnul.fs._address._route.division_._div._dir.DntI doc = null)
		{
			return Dsts(
				new nilnul.fs.Folder1(folder), doc
			);
		}

		static public IEnumerable<_address._route.division_._div. DstI> Dsts_ofAddress(string folderAddress, nilnul.fs._address._route.division_._div._dir.DntI doc=null )
		{
			return Dsts(new DirectoryInfo(folderAddress), doc);
		}

	}
}
