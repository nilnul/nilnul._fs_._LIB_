using System;
using System.IO;

namespace nilnul.fs.file_.shortcut_._url
{
	static public class _CreateX
	{
		static public void Create(string container, string main, string url)

		{

			string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

			using (
				StreamWriter writer = new StreamWriter(System.IO.Path.Combine(container, main + ".url"))
			)

			{

				writer.WriteLine("[InternetShortcut]");

				writer.WriteLine("URL=" + url);

				writer.Flush();

			}

		}


	}
}
