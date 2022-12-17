using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace nilnul.fs.locations.zip_
{
	public static class _ToFileX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="contents"></param>
		/// <param name="zipFile"></param>
		/// <returns></returns>
		public static nilnul.fs.FileI File(
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

				// add entries
				//. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

			}  // here it is saved and closed

			return new nilnul.fs.File(address);

		}

		public static nilnul.fs.FileI File(
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
			return File(
				contents, new address_.spear_.Creatable(zipFile)
			);
		}
		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, nilnul.fs._location_.BlankI> locations
			,
			string zipFile
		)
		{
			obj.Dict<_address._dst.denote.str_.seq.Join, _location_.BlankI, _address._dst.denote.str_.seq.Eq> dict = new nilnul.obj.Dict<
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
						nilnul.fs._address._dst.denote.str_.seq.Join.Parse(x.Key)

							,
							x.Value
						);
				}
			);

			return File(dict, new address_.spear_.Creatable(zipFile));


		}


		public static nilnul.fs.FileI File_ofAddresses(
			Dictionary<string, string> locations
			,
			string zipFile
		)
		{
			obj.Dict<_address._dst.denote.str_.seq.Join, _location_.BlankI, _address._dst.denote.str_.seq.Eq> dict = new nilnul.obj.Dict<
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
						nilnul.fs._address._dst.denote.str_.seq.Join.Parse(x.Key)

							,
						nilnul.fs._location_.BlankIX.FroAddress(
							x.Value
						)
					);
				}
			);

			return File(dict, new address_.spear_.Creatable(zipFile));





		}

	}
}
