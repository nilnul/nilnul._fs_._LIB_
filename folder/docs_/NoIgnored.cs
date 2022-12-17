using nilnul.fs._address;
using nilnul.fs.folder_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.docs_
{
	/// <summary>
	/// per a setting.
	/// </summary>
	static public class _UnignoredX
	{
	

		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public IEnumerable<DocI> Docs(DirectoryInfo folder, nilnul.fs._address.DocI doc=null)
		{
			var ignoredDenotes = nilnul.fs.folder.denotes_._IgnoredX.Set_froIgnoreDoc(folder, doc);

			return nilnul.fs.folder._DocsX.Docs(folder).Where(d => ignoredDenotes.NotContain(d.denote));

		}

		public static IEnumerable<_address._route.division_._div._dir.DntI> Docs(
			DirectoryInfo directoryInfo
			,
			_address._route.division_._div._dir.DntI doc
		)
		{
			var ignoredDenotes = nilnul.fs.folder.dnts_._IgnoredX.Set_froIgnoreDoc(
				directoryInfo
				,
				doc
			);

			return nilnul.fs.folder._DocsX.Docs1(directoryInfo).Where(
				d => !ignoredDenotes.Contains(d)
			);

		}

		static public IEnumerable<DocI> Docs_ofAddress(string folderAddress, nilnul.fs._address.DocI doc=null)
		{
			return Docs(new DirectoryInfo(folderAddress),doc);
		}

		public static IEnumerable<DocI> Docs(nilnul.fs.FolderI f, nilnul.fs._address.DocI doc=null)
		{
			return Docs(
				nilnul.fs.folder.to_._InfoX.To(f)
				,doc
			);
		}

		public static IEnumerable<_address._route.division_._div._dir.DntI> Docs(FolderI1 folder, _address._route.division_._div._dir.DntI doc)
		{

			return Docs(
				nilnul.fs.folder.op_.to_._InfoX.To(folder)
				,doc
			);

		}


		/// <summary>
		/// only dirName
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		public static IEnumerable<nilnul.fs._address.DocI> Docs(nilnul.fs.AddressI folder, nilnul.fs._address.DocI doc=null)
		{
			return Docs_ofAddress(folder.ToString(),doc);
		}
	






	}
}
