using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip.of_
{
	/// <summary>
	/// if location is nul, a div is created.
	/// if location is file, a document of the same ext is created.
	/// </summary>
	static public class LocationNulS
	{

		public static nilnul.fs.FileI File_ofLocationNulable(
		nilnul.obj.Dict<
			nilnul.fs._address._dst.denote.str_.seq.Join
			,
			nilnul.fs._location_.BlankI
			,
			nilnul.fs._address._dst.denote.str_.seq.Eq
		> contents
		,
		nilnul.fs.address_.spear_.Creatable zipFile

	)
		{
			string address = zipFile.en.ToString();

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create)
			)
			{

				foreach (KeyValuePair<fs._address._dst.denote.str_.seq.Join, fs._location_.BlankI> item in contents)
				{
					switch (item.Value)
					{
						case null:

							archive.CreateEntry(
									item.Key.toDenotesCapped().ToString()
								);

							break;

						case nilnul.fs.FileI file:

							archive.CreateEntryFromFile(
								file.file.en.ToString(), item.Key.ToString() + nilnul.fs.address_.spear._DocExtX.Ext(file.file.en)
								);

							break;
						case nilnul.fs.FolderI folder:

							IEnumerable<fs._address.DocumentI> documents = nilnul.fs.folder._DocumentsX.Documents(folder);
							if (documents.Any())
							{
								foreach (fs._address.DocumentI document2zip in nilnul.fs.folder._DocumentsX.Documents(folder))
								{
									fs._address.document_.DenotesDocument key = new nilnul.fs._address.document_.DenotesDocument(item.Key, document2zip);// item.Key + "/" + d1;
									archive.CreateEntryFromFile(
										new nilnul.fs.address_.spear_.ParentDocument(folder.address.en, document2zip).ToString()
										,
										key.ToString()
									);
								}

							}

							foreach (fs._address.Div emptyDiv in nilnul.fs.folder.divs_._EmptyX.Divs(folder))
							{

								fs._address._dst.denote.str.join.Capped key = new nilnul.fs._address._dst.denote.str.join.Capped(
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

				// add entries
				//. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

			}  // here it is saved and closed

			return new nilnul.fs.File(address);

		}

		public static nilnul.fs.FileI File_ofLocationNulable(
			nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			> contents
			,
			string zipFile
		)
		{
			return File_ofLocationNulable(
				contents, new fs.address_.spear_.Creatable(zipFile)
			);
		}
		public static nilnul.fs.FileI File_ofAddressNulable(
			Dictionary<string, nilnul.fs._location_.BlankI> locations
			,
			string zipFile
		)
		{
			obj.Dict<fs._address._dst.denote.str_.seq.Join, fs._location_.BlankI, fs._address._dst.denote.str_.seq.Eq> dict = new nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						new nilnul.fs._address._dst.denote.str_.seq.Join(
							nilnul.fs._address.Division0RouteX.GetDivision(
							x.Key
							)
						)

							,
							x.Value
						);
				}
			);

			return File_ofLocationNulable(dict, new fs.address_.spear_.Creatable(zipFile));


		}


		public static nilnul.fs.FileI File_ofAddressNulable(
			Dictionary<string, string> locations
			,
			string zipFile
		)
		{
			var dict = new Dictionary<
				string
				,
				nilnul.fs._location_.BlankI

			>();

			locations.ForEach(
				x =>
				{
					dict.Add(
						x.Key


							,
						x.Value is null ? null :
						nilnul.fs._location_.BlankIX.FroAddress(
							x.Value
						)
					);
				}
			);

			return File_ofAddressNulable(dict, (zipFile));





		}

	}
}
