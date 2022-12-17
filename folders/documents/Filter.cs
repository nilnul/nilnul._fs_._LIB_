using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.documents
{
	static public class _FilterX
	{
		static public IEnumerable<FileInfo> Infos(IEnumerable<DirectoryInfo> folderInfo, Predicate<FileInfo> predicate)
		{
			return nilnul.fs.folders._DocumentsX.Infos(folderInfo).Where(t=>predicate(t));
		}

		static public IEnumerable<FileInfo> Infos_ofAddresses(IEnumerable<string> folderInfo, Predicate<FileInfo> predicate)
		{
			return Infos(
				folderInfo.Select(x=> new DirectoryInfo(x))
				,
				predicate
			);
		}

		
	}
}
