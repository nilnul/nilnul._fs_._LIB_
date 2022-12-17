using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.divisions_
{

	[Obsolete()]
	static public class _Self0UnignoredX
	{

		static public IEnumerable<_address.DivisionI> Divisions(nilnul.fs.FolderI folder, _address.DocI ignoreDoc)
		{

			yield return  new _address.Div();

			foreach (var dst in fs.folder.dsts_._UnignoredX.Dsts(folder, ignoreDoc))
			{

				switch (dst)
				{
					case _address.DocI doc:
						yield return doc;
						break;
					case _address.DirI dir:
						foreach (
							var division in fs.folder.divisions_._Self0UnignoredX.Divisions(
								new nilnul.fs.address_.shield_.BaseDir(folder.address.en, dir)
								,
								ignoreDoc
							).Select( dir_s_Division => _address.division_._DirDivisionX.Concat(dir, dir_s_Division) )
						)
						{
							yield return division;
						}
						break;
					default:
						throw new UnexpectedTypeException(
							$"{dst} is neither doc nor dir"
						);
						break;
				}
			}

			



		}

	

		static public IEnumerable<_address.DivisionI> Divisions( fs.address_.ShieldI shield, _address.DocI ignoreDoc) {
			return Divisions(
				new nilnul.fs.Folder(shield)
				,

				ignoreDoc
			);
		}

	

	}
}
