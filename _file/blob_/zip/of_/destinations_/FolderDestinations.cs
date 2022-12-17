using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip.of_
{
	/// <summary>
	/// if location is empty folder, a div is created.
	/// if location is file, a document of the same ext is created.
	/// </summary>
	static public class _FolderDestinationS
	{

		public static void Vod(
		 nilnul.fs.FolderI folder
		,
		nilnul.fs.address_.spear_.newable_.ext_.Zip zipFile

	)
		{
			string address = zipFile.en.ToString();

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create
				)
			)
			{

				foreach (var item in nilnul.fs.folder._DestinationsX.Destinations(folder))
				{
					switch (item)
					{


						case nilnul.fs._address.DocumentI file:

							archive.CreateEntryFromFile(
								new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, file).ToString()
								,
								item.ToString()
							);

							break;
						case nilnul.fs._address.DirectoryI directory:

							var subFolder = nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(folder.address.en, directory);

							////IEnumerable<fs._address.DocumentI> documents = nilnul.fs.folder._DocumentsX.Documents(subFolder);


							//foreach (fs._address.DocumentI document2zip in nilnul.fs.folder._DocumentsX.Documents(subFolder))
							//{
							//	fs._address.document_.BaseDocument key = new nilnul.fs._address.document_.BaseDocument(directory, document2zip);// item.Key + "/" + d1;

							//	archive.CreateEntryFromFile(
							//		new nilnul.fs.address_.spear_.ParentDocument(subFolder, document2zip).ToString()
							//		,
							//		key.ToString()
							//	);
							//}

							if (nilnul.fs.folder.be_.Empty.Singleton.be(subFolder) )
							{


								archive.CreateEntry(
									directory.ToString()
								);

							}
							break;

						default:
							throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
							break;
#pragma warning restore CS0162 // Unreachable code detected
					}
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
