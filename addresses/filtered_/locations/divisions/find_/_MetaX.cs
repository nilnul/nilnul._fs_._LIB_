using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs.addresses.filtered_.locations.divisions.find_
{
	/// <summary>
	/// including data and (content of .dossier or other files)
	/// </summary>
	static public class _MetaX
	{
		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<AddressI> addresses
			, Regex predicate
		)
		{
			return nilnul.fs.locations._FindX.File0FolderS(
				addresses.Where(
				x => nilnul.fs.address.be_.Location.Singleton.be(x)
			)
				,
				predicate
			);
		}

		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<string> shields
			, Predicate<File0FolderI> predicate
		)
		{
			return nilnul.fs.locations._FindX.File0FolderS_ofAddresses(
				shields.Where(
					x => nilnul.fs.address.be_.Location.Singleton.be(x)
				)
				,
				predicate
			);
		}
	}
}
