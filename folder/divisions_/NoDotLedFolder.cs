using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.divisions_
{
	public class NoDotLedFolder
	{
		public IEnumerable<nilnul.fs.File0FolderI> Divisions(nilnul.fs.FolderI folder) {

			return nilnul.fs.folder._DivisionsX.Locations(folder).Where(
				s=> nilnul.fs.location.be_.File.Singleton.be(s)
				|| 
				nilnul.fs.location_.file0Folder._LocalNameX.LocalName(s).StartsWith(".")
			);
  
		}
	}
}
