using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield_.newable0empty.destinations
{
	/// <summary>
	/// to prepare a pac.
	/// if key is nul or empty or "/" or "\", it's ignored.
	/// if val is nul, empty folder is created.
	/// if val is folder, a soft link is created.
	/// if val is file, a soft link is created.
	/// if val is address_.nonExistent, exception is thrown.
	/// </summary>
	static public class _LinkX
	{
		static public void Link(nilnul.fs.address_.shield_.Newable0empty empty, folder_.empty.destinations._link.Dict locationNulS)
		{
			nilnul.fs.folder._EnsureX.Void(empty);


			nilnul.fs.folder_.empty.destinations._LinkX.Link(

				nilnul.fs.folder._EnsureX.Folder(empty)
				,
				locationNulS
			);
		}
		public static void Link(nilnul.fs.address_.shield_.Newable0empty empty, IEnumerable<KeyValuePair<DestinationI, ILocation>> enumerable)
		{
			Link(
				empty
				,
				 folder_.empty.destinations._link.Dict.Ov(enumerable)
			);

		}


		static public void Link_ofAddresses(string folder, Dictionary<string,string> locationNuls) {
			Link(
				new nilnul.fs.address_.shield_.Newable0empty (
					Shield.FroAddress(
					folder
					)
				)
				,
				locationNuls.Select				(
					x=> new KeyValuePair<_address.DestinationI, nilnul.fs.ILocation>(
						_address.DestinationA.Parse(x.Key)
						,
						nilnul.fs.LocationA.Location(x.Value)
					)

				)
			);

		}
		//static public void Link_ensureFolder(string folder, Dictionary<string, string> locationNuls) {

		//	Link_ofAddresses(folder, locationNuls);
		//}

	}
}
