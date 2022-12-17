using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace nilnul.fs.locations.zip_
{
	public static class _ToMemX
	{
		//Thanks to https://stackoverflow.com/a/12350106/222748 I got:
		public static MemoryStream MemStream(
			nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			> contents
		)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ZipArchive archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))//So we need to call dispose on ZipArchive before we can use it, which means passing 'true' as the third parameter to the ZipArchive so we can still access the stream after disposing it.
				{
					foreach (KeyValuePair<_address._dst.denote.str_.seq.Join, _location_.BlankI> item in contents)
					{
						switch (item.Value)
						{
							case nilnul.fs.FileI file:

								archive.CreateEntryFromFile(file.file.en.ToString(), item.Key.ToString());

								break;
							case nilnul.fs.FolderI folder:

								IEnumerable<_address.DocumentI> documents = nilnul.fs.folder._DocumentsX.Documents(folder);
								if (documents.Any())
								{
									foreach (_address.DocumentI d1 in nilnul.fs.folder._DocumentsX.Documents(folder))
									{
										_address.document_.DenotesDocument key = new nilnul.fs._address.document_.DenotesDocument(item.Key, d1);// item.Key + "/" + d1;
										archive.CreateEntryFromFile(
											new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, d1).ToString()
											,
											key.ToString()
										);
									}

								}

								foreach (_address.Div emptyDiv in nilnul.fs.folder.divs_._EmptyX.Divs(folder))
								{

									_address._dst.denote.str.join.Capped key = new nilnul.fs._address._dst.denote.str.join.Capped(
										item.Key.Concat(
											emptyDiv.dirs.Select(x => (x.denote))
										)

									);// item.Key + "/" + d1;

									archive.CreateEntry(
										key.ToString()
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

					//var demoFile = archive.CreateEntry("foo.txt");
					//using (var entryStream = demoFile.Open())
					//using (var streamWriter = new StreamWriter(entryStream))
					//{
					//	streamWriter.Write("Bar!");
					//}
				}

				return memoryStream;


			}
		}




	}
}
