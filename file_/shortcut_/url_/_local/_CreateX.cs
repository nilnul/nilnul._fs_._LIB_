using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.shortcut_.url_._local
{
	[nilnul.InWorking()]
	class _CreateX
	{
		private void appShortcutToDesktop(string linkName)
		{
			string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

			using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
			{
				string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
				writer.WriteLine("[InternetShortcut]");
				writer.WriteLine("URL=file:///" + app);
				writer.WriteLine("IconIndex=0");
				string icon = app.Replace('\\', '/');
				writer.WriteLine("IconFile=" + icon);
				writer.Flush();
			}
		}
	}
}
