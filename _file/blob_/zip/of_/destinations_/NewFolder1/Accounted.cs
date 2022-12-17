using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._file.blob_.zip.of_.destinations_
{
	/// <summary>
	/// excluding those ignored according to config doc, as well as those with name set according to convention
	/// if location is nul, a div is created.
	/// if location is file, a document of the same ext is created.
	/// </summary>
	///
	[Obsolete()]
	static public class _AccountedX
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

				foreach (var item in nilnul.fs.folder.destinations_._AccountedX.Destinations(folder))
				{
					var item1 = nilnul.fs._address.DestinationA.Document0Directory(item);


					switch (item1)
					{

						case nilnul.fs._address.DocumentI document00:


							archive.CreateEntryFromFile(

								nilnul.fs.address._OverlongX.PrependIfNeed(
								new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, document00)) //.ToString()
								,
								item.ToString()
							);



							break;
						case nilnul.fs._address.DirectoryI directory:

							if (nilnul.fs.folder.be_.Empty.Singleton.be(
nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(folder.address.en, directory)
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
