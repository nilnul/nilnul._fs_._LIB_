using nilnul.fs._address;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using D = nilnul.fs._address._route.division_._div._dir.DntI;

namespace nilnul.fs.folder.docs_
{
	/// <summary>
	/// excluding ingored per doc as well per convention
	/// </summary>
	static public class _ConsideredX
	{
		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.DntI> Docs(
			nilnul.fs.FolderI1 folder
			,
			nilnul.fs._address._route.division_._div._dir.DntI  doc =null
		)
		{
			return docs_._UnignoredX.Docs(folder, doc).Where(
				d => !(
					d.caption.en.Contains("(~)")
					|| d.caption.en.StartsWith("~)")
					|| d.caption.en.EndsWith("(~")
					|| d.caption.en.StartsWith(".")		//such as ".git"
				)
			);
		}

		public static IEnumerable<D> Docs(
			nilnul.fs.Folder1 folder, nilnul.fs._address._route.division_._div._dir.DntI  doc = null)
		{
			return Docs((FolderI1)folder, doc);
		}

		static public IEnumerable<D> Docs(
			DirectoryInfo folder
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc = null
		)
		{
			return Docs(
				new nilnul.fs.Folder1(folder), doc
			);
		}

		static public IEnumerable<D> Docs_ofAddress(
			string folderAddress
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc=null
		)
		{
			return Docs(new DirectoryInfo(folderAddress), doc);
		}

		static public IEnumerable<nilnul.fs.address_.spear_.based_.Child1> Addresses_ofAddress(
			string folderAddress
			,
			nilnul.fs._address._route.division_._div._dir.DntI doc=null
		)
		{
			return Docs_ofAddress(folderAddress, doc).Select(
				d =>
				 nilnul.fs.address_.spear_.based_.Child1.OfContainerAsAddress(
					 folderAddress
					 ,
					 d
				)
			) ;
		}


	}
}
