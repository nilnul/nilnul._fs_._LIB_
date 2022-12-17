using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.divisions_
{

	static public class _Self0consideredX
	{

		static public IEnumerable<_address._route.DivisionI> Divisions(nilnul.fs.FolderI1 folder, _address._route.division_._div._dir.DntI ignoreDoc)
		{

			yield return  new _address._route.division_.Div();

			foreach (var dst in fs.folder.dsts_._ConsideredX.Dsts(folder, ignoreDoc))
			{

				switch (dst)
				{
					case _address._route.division_._div._dir.DntI doc:
						yield return doc;
						break;
					case _address._route.division_._div.DirI dir:
						foreach (
							var division in Divisions(
								new nilnul.fs.address_.shield_.based_.Child(folder.address.ee, dir)
								,
								ignoreDoc
							).Select( dir_s_Division => _address._route.division_._DirDivisionX.Concat(
								dir
								,
								dir_s_Division
								)
							)
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

	

		static public IEnumerable<_address._route.DivisionI> Divisions( fs.address_.ShieldI1 shield, _address._route.division_._div._dir.DntI ignoreDoc) {
			return Divisions(
				new nilnul.fs.Folder1(shield)
				,

				ignoreDoc
			);
		}

	

	}
}
