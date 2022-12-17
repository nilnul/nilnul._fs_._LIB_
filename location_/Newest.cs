using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_
{
	/// <summary>
	/// given an address, get the newest location
	/// </summary>
	static public class _NewestX
	{
		static public ILocation Location0nul(fs.address_.spear_.ParentDoc spear) {
			var dst= nilnul.fs.folder.dst_.vered_._NewestX.VeredOrNul(spear.parent, spear.doc);
			if (dst is null)
			{
				return null;
			}
			return nilnul.fs.folder._DstX.Location_dntAssumeExists(
				spear.parent
				,
				dst
			);

			

		}
		static public ILocation Location0nul(fs.address_.SpearI spear) {

			return Location0nul(
				new address_.spear_.ParentDoc(spear)
			);
		}
		static public ILocation Location0nul(fs.AddressI address) {
			switch (address)
			{
				case fs.address_.SpearI spear:
					return Location0nul(spear);
				case fs.address_.ShieldI shiedl:
					return fs.folder_._NewestX.Folder0nul(shiedl);

				default:
					throw new UnexpectedTypeException(
						$"{address} shall be spear or shield"
					);
					break;
			}

		}


	}
}
