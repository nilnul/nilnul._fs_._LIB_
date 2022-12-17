using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.destinations_
{

	/// <summary>
	/// the documents and the directories
	/// </summary>
	///
	[Obsolete()]
	static public class _UnignoredX
	{
	
		/// <summary>
		/// short first
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="ignoreDoc"></param>
		/// <returns></returns>
		static public IEnumerable<DestinationI> Destinations(nilnul.fs.FolderI folder, _address.DocI ignoreDoc=null) {
			ignoreDoc = ignoreDoc ?? dnts_._ignored.SettingsX.Doc;

			return nilnul.fs.folder.dsts_._UnignoredX.Dsts(folder,ignoreDoc).SelectMany(
				d => {
					switch (d)
					{
						case _address.DocI doc:
							return  ( (new []{ doc }).Cast<DestinationI>() );
							break;
						case _address.DirI dir:
							return 
							  nilnul.fs.folder.divisions_._Self0UnignoredX.Divisions(
								new nilnul.fs.folder_.ParentDir(
									folder.address.en, dir
								)
								,
								ignoreDoc
							).Select(
								  div=>  _address.destination_._DirDivisionX.Destination( dir, div)
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
		static public IEnumerable<DestinationI> Destinations_ofAddress(string folder, _address.DocI ignoreDoc=null) {
			return Destinations(
				nilnul.fs.Folder.FroAddress(folder),ignoreDoc
				);

			
			

			
		}
	}
}
