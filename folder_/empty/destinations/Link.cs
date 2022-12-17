using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.empty.destinations
{
	/// <summary>
	/// to prepare a pac.
	/// if key is nul or empty or "/" or "\", it's ignored.
	/// if val is nul, empty folder is created.
	/// if val is folder, a soft link is created.
	/// if val is file, a soft link is created.
	/// if val is address_.nonExistent, exception is thrown.
	/// </summary>
	///

	static public class _LinkX
	{
		static public void Link(nilnul.fs.folder_.Empty empty, _link.Dict locationNulS)
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
							nilnul.fs.folder.Directory.CreateFroContainerDirectory(empty, kv.Key);
							break;
						case nilnul.fs.FileI file:
							nilnul.fs.file_.link_._SymX.Create(
								new nilnul.fs.address_.spear_.ParentDocument(empty.address.en,(_address.DocumentI) kv.Key)
									,
									file

								);
							break;
						case nilnul.fs.FolderI folder:
							nilnul.fs.folder_.link._CreateX.Void(
								new nilnul.fs.address_.shield_.BaseDiv(empty.address.en, (_address.DirectoryI)kv.Key)
														,
									folder.address.en
							);
							break;

						default:
							throw new UnexpectedTypeException($"{kv.Value} shall be null, file, or folder");
							break;
					}

				}
			);
		}

		static public void Link(nilnul.fs.FolderI empty, _link.Dict locationNulS)
		{
			Link(
				new folder_.Empty(empty)
				, locationNulS
				);
		}

		public static void Link(Empty empty, IEnumerable<KeyValuePair<DestinationI, ILocation>> enumerable)
		{
			Link(
				empty
				,
				 _link.Dict.Ov(enumerable)
			);

		}


		static public void Link(string folder, Dictionary<string,string> locationNuls) {
			Link(
				nilnul.fs.folder_.Empty.OvAddress(folder)
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
		static public void Link_ensureFolder(string folder, Dictionary<string, string> locationNuls) {
			nilnul.fs.folder._EnsureX.Void_ofAddress(folder);

			Link(folder, locationNuls);
		}

	}
}
