using System.Diagnostics;

namespace nilnul.fs.file.explore_
{
	/// <summary>
	/// by process.start
	/// </summary>
	static public class _SelX
	{


		static public void Vod(nilnul.fs.FileI file)
		{
			Process.Start("explorer.exe", $"/select,\"{file.ToString()}\"");
		}

		static public void Vod(nilnul.fs.address_.SpearI shield)
		{
			Vod(new nilnul.fs.File(shield));
		}

		static public void Vod(string shield)
		{
			Vod(nilnul.fs.address_.Spear.Parse(shield));
		}


	}
}
