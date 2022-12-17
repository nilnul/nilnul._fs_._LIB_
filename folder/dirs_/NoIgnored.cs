using nilnul.fs._address;
using nilnul.fs.folder_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dirs_
{
	static public class _UnignoredX
	{
	

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<DirI> Dirs(DirectoryInfo folder, nilnul.fs._address.DocI doc)
		{
			var ignoredDenotes = nilnul.fs.folder.denotes_._IgnoredX.Set_froIgnoreDoc(folder, doc);

			return nilnul.fs.folder._DirsX.Dirs(folder).Where(d => nilnul.obj.SetX.NotContain(

			ignoredDenotes, (d.denote)
			));

		}

		public static IEnumerable<_address._route.division_._div.DirI> Dirs(
			DirectoryInfo directoryInfo
			,
			_address._route.division_._div._dir.DntI doc=null
		)
		{
			var ignoredDenotes = nilnul.fs.folder.dnts_._IgnoredX.Set_froIgnoreDoc(
				directoryInfo
				,
				doc
			);
			return nilnul.fs.folder._DirsX.Dirs1(directoryInfo).Where(
				d => nilnul.obj.SetX.NotContain(
					ignoredDenotes, (d.caption)
				)
			);
		}

		static public IEnumerable<DirI> Dirs_ofAddress(string folderAddress, nilnul.fs._address.DocI doc)
		{
			return Dirs(new DirectoryInfo(folderAddress),doc);
		}

		public static IEnumerable<DirI> Dirs(
			nilnul.fs.FolderI f
			,
			nilnul.fs._address.DocI doc
		)
		{
			return Dirs(
				nilnul.fs.folder.to_._InfoX.To(f)
				,doc
			);
		}
		public static IEnumerable<_address._route.division_._div.DirI> Dirs(
			FolderI1 folder
			,
			_address._route.division_._div._dir.DntI doc=null
		)
		{
			return Dirs(
				nilnul.fs.folder.op_.to_._InfoX.To(folder)
				,
				doc
			);

		}



		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.AddressI folder, nilnul.fs._address.DocI doc)
		{
			return Dirs_ofAddress(folder.ToString(),doc);
		}
	






	}
}
