using nilnul.fs._address;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using D = nilnul.fs._address._route.division_._div.DirI;

namespace nilnul.fs.folder.dirs_
{
	/// <summary>
	/// excluding ingored per doc as well per convention
	/// </summary>
	static public class _ConsideredX
	{
		public static IEnumerable<nilnul.fs._address._route.division_._div.DirI> Dirs(
			nilnul.fs.FolderI1 folder
			,
			nilnul.fs._address._route.division_._div._dir.DntI  doc =null
		)
		{
			return dirs_._UnignoredX.Dirs(folder, doc).Where(
				d => !(
					d.caption.en.Contains("(~)")
					|| d.caption.en.StartsWith("~)")
					|| d.caption.en.EndsWith("(~")
					|| d.caption.en.StartsWith(".")		//such as ".git"
				)
			);
		}

		public static IEnumerable<D> Dirs(
			nilnul.fs.Folder1 folder, nilnul.fs._address._route.division_._div._dir.DntI  doc = null)
		{
			return Dirs((FolderI1)folder, doc);
		}

		static public IEnumerable<D> Dirs(
			DirectoryInfo folder
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc = null
		)
		{
			return Dirs(
				new nilnul.fs.Folder1(folder), doc
			);
		}

		static public IEnumerable<D> Dirs_ofAddress(
			string folderAddress
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc=null
		)
		{
			return Dirs(new DirectoryInfo(folderAddress), doc);
		}

		static public IEnumerable<nilnul.fs.address_.shield_.based_.Child> BasedShields_ofAddress(
			string folderAddress
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc=null
		)
		{
			return Dirs_ofAddress(folderAddress, doc).Select(
				d =>
				 nilnul.fs.address_.shield_.based_.Child.OfContainerAddress(
					 folderAddress
					 ,
					 d
				)
			) ;
		}


	}
}
