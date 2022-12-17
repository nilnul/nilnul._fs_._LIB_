using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.shortcut.create_
{
	static public class _ByClsIdX
	{
		static void Main(string shortcut, string target)
		{
			Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
			dynamic shell = Activator.CreateInstance(t);
			try
			{
				var lnk = shell.CreateShortcut(shortcut); //,   "sc.lnk");
				try
				{
					lnk.TargetPath = target;
					lnk.IconLocation = "shell32.dll, 1";
					lnk.Save();
				}
				finally
				{
					Marshal.FinalReleaseComObject(lnk);
				}
			}
			finally
			{
				Marshal.FinalReleaseComObject(shell);
			}
		}
	}
}
