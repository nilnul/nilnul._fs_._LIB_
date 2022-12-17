﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip.of_.documents_
{
	/// <summary>
	/// if location is nul, a div is created.
	/// if location is file, a document of the same ext is created.
	/// </summary>
	static public class _UnignoredX
	{
		//public const string ZipIgnoreDoc = ".ignore";

		//static public IEnumerable<string> ignores(nilnul.fs.FolderI folder)
		//{
		//	var spear = new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, ZipIgnoreDoc);

		//	if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
		//	{
		//		return nilnul.blob_.txt_.lines._AsSeqX.NoWhite_Trim(spear.ToString());
		//	}
		//	return new string[0];
		//}


	public static void Vod_tgtAssumeContainerExist(
		 nilnul.fs.FolderI folder
		,
		nilnul.fs.address_.spear_.newable_.ext_.Zip zipFile

	)
		{
			//System.IO.Directory.CreateDirectory(
			//	nilnul.fs.address_.spear._ContainerX.Shield(zipFile.en).ToString()
			//);
			string address = zipFile.en.ToString();

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create
				)
			)
			{

				foreach (var item in nilnul.fs.folder.documents_._UnignoredX.Documents(folder))
				{
					

							archive.CreateEntryFromFile(

								nilnul.fs.address._OverlongX.PrependIfNeed(
								new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, item)) //.ToString()
								,
								item.ToString()
							);



						
				}

				// add entries
				//. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

			}  // here it is saved and closed



		}
		public static void Vod(
		 nilnul.fs.FolderI folder
		,
		nilnul.fs.address_.spear_.newable_.ext_.Zip zipFile

	)
		{
			//System.IO.Directory.CreateDirectory(
			//	nilnul.fs.address_.spear._ContainerX.Shield(zipFile.en).ToString()
			//);
			string address = zipFile.en.ToString();

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create
				)
			)
			{

				foreach (var item in nilnul.fs.folder.documents_._UnignoredX.Documents(folder))
				{
					

							archive.CreateEntryFromFile(

								nilnul.fs.address._OverlongX.PrependIfNeed(
								new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, item)) //.ToString()
								,
								item.ToString()
							);



						
				}

				// add entries
				//. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

			}  // here it is saved and closed



		}

		public static void Vod(
			nilnul.fs.FolderI contents
			,
			string zipFile
		)
		{
			Vod(
			   contents, new fs.address_.spear_.newable_.ext_.Zip(zipFile)
		   );
		}





		public static void Vod_ofAddress(
			string locations
			,
			string zipFile
		)
		{
			Vod(nilnul.fs.Folder.FroAddress(locations), (zipFile));

		}

		public static void Vod_ensureExt(
			nilnul.fs.FolderI contents
			,
			string zipFile
		)
		{
			Vod(
			   contents,
			   nilnul.fs.address_.spear.op_.unary_._EnsureDweltExtX.Txt(zipFile, ".zip")

		   );
		}
		public static void Vod_ensureExt(
			string contents
			,
			string zipFile
		)
		{
			Vod_ensureExt(
			   nilnul.fs.Folder.FroAddress(contents)
			   ,
			   zipFile

		   );
		}


	}
}
