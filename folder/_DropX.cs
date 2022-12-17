using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace nilnul.fs.folder
{
	static public class _DropX
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool RemoveDirectoryW(string path);


		/// <summary>
		/// not fully recyclable
		/// </summary>
		/// <param name="src"></param>
		static public void Vod(
			nilnul.fs.FolderI src
			)
		{
			var address = src.ToString();
			if (address.Length < nilnul.fs.address._OverlongX.MAX_LENGTH)
			{

				System.IO.Directory.Delete(address, true);
				return;
			}

			#region use DllImport of unicode version; must on empty folder

			nilnul.fs.folder.dsts._DelX.Del(
				src
			);

			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(
				RemoveDirectoryW(
					nilnul.fs.address._OverlongX.PrependIfNeed(address)
				)
			);

			#endregion

			#region throw System.IO.DirectoryNotFoundException if path too long
			//System.IO.Directory.Delete(
			//	src.ToString()
			//	,
			//	true
			//);
			#endregion

			#region  System.IO.IOException: 文件名、目录名或卷标语法不正确 if path too long
			//System.IO.Directory.Delete(
			//	nilnul.fs.address._OverlongX.PrependIfNeed(src)
			//	,
			//	true
			//);

			#endregion

			//_Vod(
			//	parent.address.en

			//);
		}

		//public static void Vod(BaseDir src)
		//{
		//	System.IO.Directory.Delete(src.ToString(),true);
		//}

		public static void Vod(nilnul.fs.address_.ShieldI src)
		{
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(src))
			{
				Vod(new nilnul.fs.Folder(src));
			}



		}
	

		public static void Vod_ofAddress(string address)
		{
			Vod(nilnul.fs.address_.Shield.FroAddress(address));
		}
	}
}
