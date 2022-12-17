using Microsoft.VisualBasic.FileIO;
using nilnul.fs.folder_.based_;
using System;

namespace nilnul.fs.folder.drop_
{
	static public class _RecyclableX
	{
		[Obsolete("as in sql, 'del' is used to drop each one in a set")]
		public static void Del(
			string folder
		)
		{
			_Drop_assumeAddressOfFolder(folder);
		}

		/// <summary>
		/// using basic.
		/// </summary>
		/// <param name="folder"></param>
		public static void _Drop_assumeAddressOfFolder(
			string folder
		)
		{
			Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(folder, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
		}
		public static void Drop(FolderI1 folder)
		{
			_Drop_assumeAddressOfFolder(folder.address.ee.ToString());

		}

		public static void Drop(
			FolderI folder
		)
		{
			_Drop_assumeAddressOfFolder(folder.address.en.ToString());
		}

		public static void Drop(
			address_.ShieldI folder
		)
		{
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(folder) )
			{
				Drop(new nilnul.fs.Folder(folder) );
			}
		}

	}
}
