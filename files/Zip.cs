using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace nilnul.fs.files
{
	public static class _ZipX
	{

		public static string ZipPrefixEmpty(params string[] files)
		{
#pragma warning disable CS0612 // '_ZipX.Zip(string, params string[])' is obsolete
			return Zip("", files);
#pragma warning restore CS0612 // '_ZipX.Zip(string, params string[])' is obsolete
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix">the dir to be created inside Tmp folder</param>
		/// <param name="files"></param>
		/// <returns></returns>
		[Obsolete()]
		public static string Zip(string prefix, params string[] files)
		{

			string address = nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(prefix, "zip");

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create)
			)
			{


				// add entries

				files.ForEach(x =>
					archive.CreateEntryFromFile(x, nilnul.fs.address_.spear_.ParentDoc.Parse(x).doc.ToString())    //. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

				);

			}  // here it is saved and closed

			return address;


		}

		public static nilnul.fs.FileI Exe(
			nilnul.txt_._vered_.Name zipFileMainName
			,
			nilnul.obj.Dict<
				nilnul.fs._address.DocI
				,
				nilnul.fs.FileI, nilnul.fs._address.doc.Eq
			> contents
		)
		{

			string address = nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(zipFileMainName, "zip");

			using (ZipArchive archive = ZipFile.Open(
				address

				,
				ZipArchiveMode.Create)
			)
			{


				// add entries

				contents.ForEach(x =>
					archive.CreateEntryFromFile(x.Value.file.en.ToString(), x.Key.ToString())    //. If an entry with the specified name (entryName) already exists in the archive, a second entry is created with an identical name. The LastWriteTime property of the entry is set to the last time the file on the file system was changed.

				);

			}  // here it is saved and closed

			return new nilnul.fs.File(address);

		}

		public static nilnul.fs.FileI Exe(string zipName, Dictionary<string, nilnul.fs.address_.SpearI> files)
		{
			var dict = new nilnul.obj.Dict<
				nilnul.fs._address.DocI
				,
				nilnul.fs.FileI
				,
				nilnul.fs._address.doc.Eq
			>();

			files.ForEach(
				x =>
				{
					dict.Add(
						new nilnul.fs._address.Doc(x.Key + nilnul.fs._address.doc_.exted._ExtX._Ext(
						x.Value.sprig.document.doc.ToString()
					))
						,
						new nilnul.fs.File(x.Value)
					);
				}
			);

			return Exe(
				new txt_._vered_.Name(zipName)
				,
				dict
			);
		}

		public static nilnul.fs.FileI Exe(string zipName, Dictionary<string, string> files)
		{
			Dictionary<string, address_.SpearI> dict = new Dictionary<string, nilnul.fs.address_.SpearI>();
			files.ForEach(
				x =>

					dict.Add(
						x.Key
						,
						new nilnul.fs.address_.Spear(x.Value)
					)


			);

			return Exe(
				zipName
				,
				dict
			);
		}
	}
}