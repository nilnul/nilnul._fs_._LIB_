using nilnul.fs._address;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{

	/// <summary>
	/// the documents and the directories
	/// </summary>
	static public class _DestinationsX
	{
	

		static public IEnumerable<DestinationI> Destinations(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder._DocumentsX.Documents(folder).Cast<DestinationI>().Concat(fs.folder._DirectoriesX.Directories(folder) );
		}
	}
}
