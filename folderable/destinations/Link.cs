using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folderable.destinations
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
		static public void Link(
			nilnul.fs.FolderableI empty
			,
			_address._route.division_.destination.byDenotation.set.map_.location0nul_.Normalized  locationNulS
		)
		{
			locationNulS.boxed.ForEach(
				kv =>
				{
					/*if (kv.Key is null)  //key cannot be null in dict
					{
						return;
					}*/

					switch (kv.Value)
					{
						case null:
							nilnul.fs.folder.create._EnsureX.Vod(empty, kv.Key);
							break;
						case nilnul.fs.FileI1 file:
							nilnul.fs.file_.link_._SymX.Create(
								new nilnul.fs.address_.spear_.based_.ParentDocument(
									empty.addressee.ee,
									(_address._route.division_.div.DntedI ) kv.Key)
									,
									file

								);
							break;
						case nilnul.fs.FolderI1 folder:
							nilnul.fs.folder_.link_.sym.create_._DllImportX.Vod(
								new nilnul.fs.address_.shield_.based_.BasedDiv(
									empty.addressee.ee
									,
									(_address._route.division_.div_.DirectoryI)kv.Key
								)
														,
									folder.address.ee
							);
							break;

						default:
							throw new UnexpectedTypeException($"{kv.Value} shall be null, file, or folder");
							break;
					}

				}
			);
		}

		static public void Link(nilnul.fs.FolderI1 empty, _address._route.division_.destination.byDenotation.set.map_.location0nul_.Normalized locationNulS)
		{
			Link(
				new Folderable(empty.address.ee)
				, locationNulS
				);
		}

		public static void Link(
			nilnul.fs.FolderableI empty
			,
			IEnumerable<KeyValuePair<_address._route.division_. DestinationI, ILocation>> enumerable
		)
		{
			Link(
				empty
				,
				 _address._route.division_.destination.byDenotation.set.map_.location0nul_.Normalized.Ov(enumerable)
			);

		}


		static public void Link(string folder, Dictionary<string,string> locationNuls) {
			Link(
				new nilnul.fs.Folderable(folder)
				,
				locationNuls.Select				(
					x=> new KeyValuePair<_address._route.division_.DestinationI, nilnul.fs.ILocation>(
						_address._route.division_.DestinationA.Parse(x.Key)
						,
						nilnul.fs.LocationA.Location1(x.Value)
					)

				)
			);

		}
		static public void Link_ensureFolder(string folder, Dictionary<string, string> locationNuls) {
			nilnul.fs.folder._EnsureX.Void_ofAddress(folder);

			Link(folder, locationNuls);
		}

	}
}
