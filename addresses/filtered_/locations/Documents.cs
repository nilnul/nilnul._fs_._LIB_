using System;
using System.Collections.Generic;
using System.Linq;


namespace nilnul.fs.addresses.filtered_.locations
{
	/// <summary>
	/// the location itself if the location is file;
	/// the documents of the location if the location if folder
	/// </summary>
	static public class _DocumentsX
	{
		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<AddressI> addresses
			, Predicate<File0FolderI> predicate
		)
		{
			return nilnul.fs.locations._DivisionsX.File0FolderS(
				nilnul.fs.addresses.filtered_._LocationsX._Locations(
					addresses
				)
			);
		}

		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<string> shields
			, Predicate<File0FolderI> predicate
		)
		{
			return _Locations(
				shields.Select(x=> nilnul.fs.AddressA.Parse(x))
				,
				predicate
			);
		}
	}
}
