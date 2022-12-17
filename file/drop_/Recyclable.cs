using Microsoft.VisualBasic.FileIO;
using nilnul.fs.address_.spear_.based_;
using System;

namespace nilnul.fs.file.drop_
{
	/// <summary>
	/// using visual basic
	/// </summary>
	static public class _RecyclableX
	{
		public static void Vod(
			string file

		)
		{
			Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
		}

		public static void DropIfFile(
			string file

		)
		{
			if (nilnul.fs.address.be_.File.Singleton.be(file))
			{
				Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);

			}
		}

		public static void DropIfFile(
			nilnul.fs.address_.SpearI file

		)
		{
			DropIfFile(file.ToString());
		}


		public static void RecycleIfFile(nilnul.fs.address_.SpearI1 file)
		{
			DropIfFile(file.ToString());

		}


		public static void Vod(
			FileI file
		)
		{
			Vod(file.file.en.ToString());
		}


		public static void Vod(
			nilnul.fs.address_.SpearI file
		)
		{
			Vod(file.ToString());
		}

	}
}
