using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{

	static public class _DivsX1
	{
		public static IEnumerable<DivI> Divs(FolderI folderInfo)
		{

			foreach (var item in  _DirectoriesX.Directories(folderInfo))
			{
				yield return item;
			}
			yield return new Div();

		}
		/// <summary>
		/// depth first
		/// </summary>
		/// <param name="info"></param>
		/// <returns></returns>
		static public IEnumerable<DivI> Divs(DirectoryInfo info)
		{
			foreach (var item in  _DirectoriesX.Directories(info))
			{
				yield return item;
			}
			yield return new Div();
		}

		public static IEnumerable<DivI> Divs(nilnul.fs.address_.ShieldI baseDir)
		{


			return Divs(
				nilnul.fs.address_.shield.to_._InfoX.Info(baseDir)
			);
		}

		
		static public IEnumerable<DirectoryInfo> Infos(DirectoryInfo info)
		{
			
			var longed = nilnul.fs.address._OverlongX.PrefixIfNeed(info.FullName);
			if (longed != info.FullName)
			{
				info = new DirectoryInfo(longed);
			}
			foreach (var item in info.EnumerateDirectories())
			{
				foreach (var item1 in Infos(item))
				{
					yield return item1;

				}
			}

			yield return info;
		}





		public static IEnumerable<DirectoryInfo> Infos(FolderI src)
		{
			return Infos(
				nilnul.fs.folder.to_._InfoX.To(src)
			);
		}


		public static IEnumerable<FolderI> Folders(DirectoryInfo info)
		{

			foreach (var item in info.EnumerateDirectories())
			{
				foreach (var item1 in Folders(item))
				{
					yield return item1;
				}
			}
			yield return (nilnul.fs.Folder)info;
		}


		static public IEnumerable<nilnul.fs.FolderI> Folders(nilnul.fs.FolderI folder)
		{
			foreach (
				var item in nilnul.fs.folder.to_.Info.Singleton.to(folder).EnumerateDirectories()
			)
			{
				foreach (var item1 in Infos(item))
				{
					yield return (nilnul.fs.Folder)item1;

				}
			}

			yield return folder;
		}


		static public IEnumerable<string> Addresses_ofAddress(string folderAddress)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(folderAddress))
			{
				foreach (var item1 in Addresses_ofAddress(item))
				{
					yield return item1;

				}
			}
			yield return folderAddress;
		}

		static public IEnumerable<DirectoryInfo> Infos_ofAddress(string folder)
		{
			return Addresses_ofAddress(folder).Select(x => new DirectoryInfo(x));
		}


	}
}
