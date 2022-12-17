using System;
using System.Collections.Generic;
using System.Linq;


namespace nilnul.fs.addresses.filtered_
{
	static public class _LocationsX
	{
		static public IEnumerable<AddressI> _Addresses(
			IEnumerable<AddressI> addresses
			
		)
		{
			return 
				addresses.Where(
					x => nilnul.fs.address.be_.Location.Singleton.be(x)
				)
			;
		}

		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<AddressI> addresses
			
		)
		{
			return 
				_Addresses(addresses).Select(x=> nilnul.fs._File0FolderX.File0Folder(x))
			;
		}

		static public IEnumerable<File0FolderI> _Locations(
			IEnumerable<string> shields
		)
		{
			return _Locations(
				shields.Select(
					x => nilnul.fs.AddressA.Parse(x)
				)
				
			);
		}
	}
}
