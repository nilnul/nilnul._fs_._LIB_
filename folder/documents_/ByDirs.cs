using nilnul.fs._address;
using nilnul.fs.folders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.documents_
{
	static public class _ByDocumentsOfEachDirX
	{


		static public IEnumerable<nilnul.fs._address.DocumentI> Documents(nilnul.fs.FolderI folderInfo)
		{



			return nilnul.fs.folder._DocsX.Docs(folderInfo).Select(
				doc => new nilnul.fs._address.Document(doc)
			).Cast<DocumentI>().Concat(

				nilnul.fs.folder._DirsX.Dirs(folderInfo).SelectMany(
					dir =>
						 Documents(
							 new nilnul.fs.address_.shield_.BaseDir(folderInfo.address.en, dir)

						).Select(
							 dirDocument =>
								new nilnul.fs._address.document_.BaseDocument(
								   dir,
								   dirDocument
							   )
						 )
					)
			);
		}

		public static IEnumerable<DocumentI> Documents(nilnul.fs.address_.ShieldI folder)
		{
			return Documents(new nilnul.fs.Folder(folder));
		}
	}


}
