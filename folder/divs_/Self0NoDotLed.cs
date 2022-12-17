using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.divs_
{

	static public class _Self0NoDotLedX
	{
		public static IEnumerable<DivI> Divs(FolderI folderInfo)
		{
			yield return new Div();

			foreach (var item in  directories_._NoDotLedX.Directories(folderInfo))
			{
				yield return item;
			}

		}
		/// <summary>
		/// depth first
		/// </summary>
		/// <param name="info"></param>
		/// <returns></returns>
		static public IEnumerable<DivI> Divs(nilnul.fs.Folder info)
		{
			return Divs((FolderI)(info));
		}
		static public IEnumerable<DivI> Divs(DirectoryInfo info)
		{
			return Divs(new nilnul.fs.Folder(info));
		}

		public static IEnumerable<DivI> Divs(nilnul.fs.address_.ShieldI baseDir)
		{


			return Divs(
				nilnul.fs.address_.shield.to_._InfoX.Info(baseDir)
			);
		}

	


	}
}
