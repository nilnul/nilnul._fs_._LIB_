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
	///
	[Obsolete()]
	static public class _AccountedX
	{
	
		public static IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.FolderI folder, nilnul.fs._address.DocI doc =null)
		{
			return dsts_._UnignoredX.Dsts(folder, doc).Where(
				d => !(
					d.denote.en.Contains("(~)")
					|| d.denote.en.StartsWith("~)")
					|| d.denote.en.EndsWith("(~")
					|| d.denote.en.StartsWith(".")		//such as ".git"
				)
			);

			


		}

		public static IEnumerable<nilnul.fs._address.DstI> Dsts(nilnul.fs.Folder folder, nilnul.fs._address.DocI doc = null)
		{
			return Dsts((FolderI)folder, doc);


		}

		static public IEnumerable<DstI> Dsts(DirectoryInfo folder, nilnul.fs._address.DocI doc = null)
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
