using nilnul.fs._address;
using nilnul.fs.folders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	static public class _DocumentsX
	{
		static public IEnumerable<FileInfo> Infos(DirectoryInfo folderInfo)
		{
			return nilnul.fs.folder._DivsX1.Infos(folderInfo).SelectMany(
				x => x.EnumerateFiles()
			);
		}

		public static IEnumerable<FileInfo> Infos(FolderI src)
		{
			return nilnul.fs.folder._DivsX1.Infos(src).SelectMany(
				x => x.EnumerateFiles()
			);

			;
		}
		public static IEnumerable<FileInfo> Infos(Folder src)
		{
			return Infos(
				(FolderI)src
			);
		}

		static public IEnumerable<nilnul.fs.File> Files(nilnul.fs.FolderI folderInfo)
		{
			return Infos(
				nilnul.fs.folder.to_.Info.Singleton.to(folderInfo)
			).Select(x => new nilnul.fs.File(x));
		}

		static public IEnumerable<nilnul.fs._address.DocumentI> Documents(nilnul.fs.FolderI folderInfo)
		{

			return nilnul.fs.folder._DivsX1.Divs(folderInfo).SelectMany(
				div =>

				nilnul.fs.folder._DocsX.Docs(
					new nilnul.fs.address_.shield_.BaseDiv(folderInfo.address.en, div)
				).Select( doc=> new Document(div,doc))
			);


			
		}

		public static IEnumerable<DocumentI> Documents(nilnul.fs.Folder folder)
		{
			return Documents( (nilnul.fs.FolderI)(folder));
		}

		public static IEnumerable<DocumentI> Documents(DirectoryInfo folder)
		{
			return Documents( new nilnul.fs.Folder(folder));
		}

		public static IEnumerable<DocumentI> Documents(nilnul.fs.address_.ShieldI folder)
		{
			return Documents( new nilnul.fs.Folder(folder));
		}


		static public IEnumerable<FileInfo> Infos_ofAddress(string folderInfo)
		{
			return Infos(new DirectoryInfo(folderInfo));
		}


		static public IEnumerable<nilnul.fs.File> Files_ofAddress(string folderInfo)
		{
			return Files(
				nilnul.fs.Folder.FroAddress(folderInfo)
			);
		}
	}
}
