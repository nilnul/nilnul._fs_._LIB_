using nilnul.fs.folder.to_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.documents_.ext_
{
	static public class _BySearchX
	{


		static public IEnumerable<FileInfo> Infos_assumeExtDotted(System.IO.DirectoryInfo folder, string ext)
		{

			return folder.EnumerateFiles($"*{ext}", SearchOption.AllDirectories);
		}

		static public IEnumerable<FileInfo> Infos_assumeExt(System.IO.DirectoryInfo folder, string ext)
		{
			if (ext == "")
			{
				return folder.EnumerateFiles().Where(

					filPath => string.IsNullOrEmpty(
						nilnul.fs.address_.spear.ext_._ByPathX.Txt(
							filPath
						)
					)
				);
			}
			else
			{
				return Infos_assumeExtDotted(folder, ext);
			}
		}



		static public IEnumerable<FileInfo> Infos(System.IO.DirectoryInfo folder, _address.doc_._exted.ExtI ext)
		{

			return Infos_assumeExt(folder, ext.ToString());
		}

		static public IEnumerable<FileInfo> Infos(System.IO.DirectoryInfo folder, _address.doc_._exted.Ext ext)
		{

			return Infos(folder, (_address.doc_._exted.ExtI)ext);
		}


		static public IEnumerable<FileInfo> Infos(System.IO.DirectoryInfo folder, string ext)
		{

			return Infos(folder,  new _address.doc_._exted.Ext(ext) );
		}

		static public IEnumerable<FileInfo> Infos_allowFolderAddress(string  folder, _address.doc_._exted.ExtI ext)
		{

			return Infos(new DirectoryInfo( folder ), ext);
		}

		static public IEnumerable<FileInfo> Infos_allowFolderAddress(string  folder, _address.doc_._exted.Ext ext)
		{

			return Infos_allowFolderAddress( folder ,  (_address.doc_._exted.ExtI)ext);
		}

		static public IEnumerable<FileInfo> Infos_allowFolderAddress(string  folder, string ext)
		{

			return Infos_allowFolderAddress(( folder ),  new _address.doc_._exted.Ext(ext) );
		}

		static public IEnumerable<nilnul.fs.File> Files_allowFolderAddress(string  folder, string ext)
		{

			return Infos_allowFolderAddress(( folder ),  (ext) ).Select(x=> new nilnul.fs.File (x));
		}



		static public IEnumerable<FileInfo> Infos_allowFolderAddress_assumeExt(string  folder, string ext)
		{

			return Infos_assumeExt(new DirectoryInfo( folder ), ext);
		}



		static public IEnumerable<fs._address.Document> Documents(System.IO.DirectoryInfo folder, string ext)
		{
			return Infos_assumeExt(folder, ext).Select(
				x =>
				nilnul.fs.address.co_.shieldSpear_.containing._DifX._Document_assumeHas(folder, x)
			);
		}


		static public IEnumerable<_address.DocumentI> Documents_folderAllowAddress(string folderAddress, string ext)
		{
			return Documents(new DirectoryInfo(folderAddress), ext);
		}

		static public IEnumerable<fs._address.Document> Documents(nilnul.fs.FolderI folder, string ext)
		{
			return Documents(folder.To(), ext);
		}


	}
}
