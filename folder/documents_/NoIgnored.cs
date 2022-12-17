using nilnul.bit.combine_;
using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.documents_
{
	static public class _UnignoredX
	{
		public static IEnumerable<_address.Document> Documents(FolderI folder)
		{
			return Documents(folder, nilnul.fs.folder.dnts_._ignored.SettingsX.Doc);

		}
		public static IEnumerable<_address.Document> Documents(FolderI folder, _address.DocI ignoreDoc)
		{

			foreach (var item in fs.folder.dsts_._UnignoredX.Dsts(folder, ignoreDoc))
			{

				switch (item)
				{
					case _address.DocI doc:
						yield return new _address.Document(doc);
						break;
					case _address.DirI dir:
						foreach (
							var document0 in fs.folder.documents_._UnignoredX.Documents(
								new nilnul.fs.address_.shield_.BaseDir(folder.address.en, dir)
								,
								ignoreDoc
							).Select(
								document => _address.denotation_._DivDenotationX.Splice(dir, document)
							)
						)
						{
							yield return document0;
						}
						break;
					default:
						throw new UnexpectedTypeException(
							$"{item} is neither doc nor dir"
						);
						break;
				}
			}
		}
		public static IEnumerable<_address.DenotationI> Denotes(nilnul.fs.address_.ShieldI folder)
		{
			return Denotes(new nilnul.fs.Folder(folder));
		}
		public static IEnumerable<_address.DenotationI> Denotes(FolderI folder)
		{

			foreach (var item in fs.folder.dsts_._UnignoredX.Dsts(folder))
			{

				switch (item)
				{
					//case _address.DocI doc:
					case _address.IDnt dnt:

						yield return new _address.Denotation(dnt);
						break;
					case _address.DirI dir:
						foreach (
							var document0 in fs.folder.documents_._UnignoredX.Denotes(
								new nilnul.fs.address_.shield_.BaseDir(folder.address.en, dir)
								
							).Select(
								document => _address.denotation_._DivDenotationX.Splice(dir, document)
							)
						)
						{
							yield return document0;
						}
						break;
					default:
						throw new UnexpectedTypeException(
							$"{item} is neither doc nor dir"
						);
						break;
				}
			}
		}

		static public IEnumerable<_address.Document> Documents(fs.address_.ShieldI shield, _address.DocI ignoreDoc)
		{
			return Documents(
				new nilnul.fs.Folder(shield)
				,

				ignoreDoc
			);
		}

		static public IEnumerable<_address.Document> Documents_ofAddress(string shield, _address.DocI ignoreDoc)
		{
			return Documents(
				 nilnul.fs.Folder.FroAddress(shield)
				,

				ignoreDoc
			);
		}




		static public IEnumerable<_address.Document> Documents(nilnul.fs.Folder folder, _address.DocI ignoreDoc)
		=> Documents((FolderI)(folder), ignoreDoc);

		static public IEnumerable<_address.Document> Documents(DirectoryInfo folder, _address.DocI ignoreDoc)
		=> Documents(new nilnul.fs.Folder(folder), ignoreDoc);


	}
}