using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.co_.disjoint
{
	/// <summary>
	/// compare the two folders and list differences
	/// </summary>
	static public class _DeltaX
	{
		static public (
			(_address.division.Set, _address.division.Set)
			,
			nilnul.fs._address.document.Set
		) _Ret_assumeDisjoint(nilnul.fs.FolderI a, nilnul.fs.FolderI b)
		{

			var divisions_a = nilnul.fs.folder._DivisionsX.Divisions(a);
			var divisions_b = nilnul.fs.folder._DivisionsX.Divisions(b);

			var divisionsDelta = nilnul.fs._address.division.set.co.convert_._DeltaX.Delta(
				divisions_a
				,
				divisions_b
			);

			var intersected = nilnul.fs._address.division.set.co.band_._IntersectX.Band(divisions_a, divisions_b);

			//folders and files
			//only files will be compared

			;

			return (
				divisionsDelta
				,
				new nilnul.fs._address.document.Set(
					intersected.Where(
						 _address.division.be_.Document.Singleton.be
					).Cast<nilnul.fs._address.DocumentI>().Where(
						d1 =>
						nilnul.fs.file.eq_.binary.Re.Singleton.ne(
							 nilnul.fs.file_._BasedX.File(a, d1)
							 ,
							 nilnul.fs.file_._BasedX.File(b, d1)
						)
					).ToArray()
				)
			);

		}

		public static (
			(_address.division.Set, _address.division.Set)
			,
			nilnul.fs._address.document.Set
		) _Ret_ofAddresses_assumeDisjoint(string v1, string v2)
		{
			return _Ret_assumeDisjoint(
				nilnul.fs.Folder.FroAddress(v1)
				,
				nilnul.fs.Folder.FroAddress(v2)
			);
		}
	}
}
