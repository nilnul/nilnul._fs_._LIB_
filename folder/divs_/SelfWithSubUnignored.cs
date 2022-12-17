using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.divs_
{

	static public class _Self0UnignoredX
	{
		public static IEnumerable<DivI> Divs(FolderI folderInfo, _address.DocI doc)
		{
			yield return new Div();

			foreach (var item in  directories_._UnignoredX.Directories(folderInfo,doc))
			{
				yield return item;
			}

		}
		/// <summary>
		/// depth first
		/// </summary>
		/// <param name="info"></param>
		/// <returns></returns>
		static public IEnumerable<DivI> Divs(nilnul.fs.Folder info, _address.DocI doc)
		{
			return Divs((FolderI)(info), doc);
		}
		static public IEnumerable<DivI> Divs(DirectoryInfo info, _address.DocI doc)
		{
			return Divs(new nilnul.fs.Folder(info), doc);
		}

		public static IEnumerable<DivI> Divs(nilnul.fs.address_.ShieldI baseDir, _address.DocI doc)
		{


			return Divs(
				nilnul.fs.address_.shield.to_._InfoX.Info(baseDir),doc
			);
		}

	


	}
}
