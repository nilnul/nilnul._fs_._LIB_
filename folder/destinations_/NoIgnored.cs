using nilnul.fs._address;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.destinations_
{

	/// <summary>
	/// the documents and the directories
	/// </summary>
	static public class _UnignoredX1
	{
	
		/// <summary>
		/// short first
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="ignoreDoc"></param>
		/// <returns></returns>
		static public IEnumerable<_address._route.division_. DestinationI> Destinations(nilnul.fs.FolderI1 folder, _address._route.division_._div._dir.DntI  ignoreDoc=null) {
			ignoreDoc = ignoreDoc ?? dnts_._ignored.SettingsX.Dnt;

			return nilnul.fs.folder.dsts_._UnignoredX.Dsts(folder,ignoreDoc).SelectMany(
				d => {
					switch (d)
					{
						case _address._route.division_._div._dir.DntI doc:
							return  ( (new []{ doc }).Cast<_address._route.division_.DestinationI>() );
							break;
						case _address._route.division_._div.DirI dir:
							return 
							  nilnul.fs.folder.divisions_._Self0unignoredX.Divisions(
								new nilnul.fs.folder_.based_.Child(
									folder.address.ee, dir
								)
								,
								ignoreDoc
							).Select(
								  div=>  _address._route.division_.destination_._DirDivisionX.Destination( dir, div)
							);
							//return new DestinationI[] { dir }.Concat(
							//	Destinations(
							//		new nilnul.fs.folder_.ParentDir(
							//			folder.address.en, dir
							//		)
							//		,
							//		ignoreDoc
							//	)
							//);
						default:
							throw new UnexpectedTypeException();
							break;
					}
				}
			);

			
		}
		static public IEnumerable<_address._route.division_. DestinationI> Destinations_ofAddress(string folder, _address._route.division_._div._dir.DntI ignoreDoc=null) {
			return Destinations(
				nilnul.fs.Folder1.FroAddress(folder),ignoreDoc
				);

			
			

			
		}
	}
}
