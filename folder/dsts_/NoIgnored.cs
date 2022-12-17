using nilnul.fs._address;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using D = nilnul.fs._address._route.division_._div.DstI;

namespace nilnul.fs.folder.dsts_
{
	static public class _UnignoredX
	{
	
		public static IEnumerable<D> Dsts(nilnul.fs.FolderI1 folder, nilnul.fs._address._route.division_._div._dir.DntI  doc =null)
		{
			var denotes = nilnul.fs.folder.dnts_._IgnoredX.Set_froIgnoreDoc(folder, doc);

			return nilnul.fs.folder._Dsts1.Dsts(folder).Where(d=> denotes.NotContain(  d.caption ) );


		}

		[Obsolete()]
		public static IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.FolderI folder, nilnul.fs._address.DocI doc =null)
		{
			var denotes = nilnul.fs.folder.denotes_._IgnoredX.Set_froIgnoreDoc(folder, doc);

			return nilnul.fs.folder._Dsts.Dsts(folder).Where(d=> denotes.NotContain(  d.denote ) );


		}

		public static IEnumerable<D> Dsts(nilnul.fs.Folder1 folder, nilnul.fs._address._route.division_._div._dir.DntI doc =null)
		{
			return Dsts((FolderI1)folder, doc);


		}

		public static IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.Folder folder, nilnul.fs._address.DocI doc = null)
		{
			return Dsts((FolderI)folder, doc);


		}


		static public IEnumerable<DstI> Dsts(DirectoryInfo folder, nilnul.fs._address.DocI doc=null )
		{
			return Dsts(
				new nilnul.fs.Folder(folder), doc
			);

			


		
		}

		static public IEnumerable<DstI> Dsts_ofAddress(string folderAddress, nilnul.fs._address.DocI doc=null )
		{
			return Dsts(new DirectoryInfo(folderAddress), doc);
		}



	






	}
}
