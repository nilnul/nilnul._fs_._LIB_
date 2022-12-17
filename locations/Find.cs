using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.locations
{
	static public class _FindX
	{
		static public IEnumerable<File0FolderI> File0FolderS_ofAddresses(
			IEnumerable<string> shields
			,
			Predicate<File0FolderI> locationBe
		)
		{
			return nilnul.fs.locations._DivisionsX.File0FolderS_ofAddresses(
				shields
			).Where(x => locationBe(x));
		}

		static public IEnumerable<File0FolderI> File0FolderS(
			IEnumerable<AddressI> shields
			,
			Predicate<File0FolderI> locationBe
		)
		{
			return nilnul.fs.locations._DivisionsX.File0FolderS(
				shields
			).Where(x => locationBe(x));
		}


		static public IEnumerable<File0FolderI> File0FolderS(
			IEnumerable<File0FolderI> shields
			,
			Predicate<File0FolderI> predicate
		)
		{
			return nilnul.fs.locations._DivisionsX.File0FolderS(
				shields
			).Where(x => predicate(x));

		}

	}
}
