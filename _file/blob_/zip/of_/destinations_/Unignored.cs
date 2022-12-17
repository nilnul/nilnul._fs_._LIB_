using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._file.blob_.zip.op_.of_.destinations_
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



		public static void Vod(
		 nilnul.fs.FolderI1 folder
		,
		nilnul.fs.address_.spear_.newable_.ext_.Zip1 zipFile

	)
		{
			string address = zipFile.ee.ToString();

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create
				)
			)
			{

				foreach (var item in nilnul.fs.folder.destinations_._UnignoredX1.Destinations(folder))
				{
					var item1 = nilnul.fs._address._route.division_.DestinationA.Denotation0directory(item);


					switch (item1)
					{

						case nilnul.fs._address._route.division_.div.DntedI document00:


							archive.CreateEntryFromFile(

								nilnul.fs.address._OverlongX.PrependIfNeed(
								new nilnul.fs.address_.spear_.based_.ParentDocument(
									folder.address.ee, document00
								)) //.ToString()
								,
								item.ToString()
							);



							break;
						case nilnul.fs._address._route.division_.div_.DirectoryI directory:

							if (nilnul.fs.folder.be_.Empty1.Singleton.be(
nilnul.fs.address_.shield_.based_.div_._DivInDivisionX.BaseDiv(folder.address.ee, directory)
								))
							{
								archive.CreateEntry(
									directory.ToString()
								);
							}
							break;
						default:
							throw new UnexpectedTypeException();
							break;
					}
				}

				// add entries
				//. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

			}  // here it is saved and closed



		}

		public static void Vod(
			nilnul.fs.FolderI1 contents
			,
			string zipFile
		)
		{
			Vod(
			   contents, new fs.address_.spear_.newable_.ext_.Zip1(zipFile)
		   );
		}





		public static void Vod_ofAddress(
			string locations
			,
			string zipFile
		)
		{
			Vod(nilnul.fs.Folder1.FroAddress(locations), (zipFile));

		}

		public static void Vod_ensureExt(
			nilnul.fs.FolderI1 contents
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
			   nilnul.fs.Folder1.FroAddress(contents)
			   ,
			   zipFile

		   );
		}


	}
}
