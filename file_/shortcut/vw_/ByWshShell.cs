using IWshRuntimeLibrary;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.file_.shortcut.vw_
{
	static public class _ByWshShellX
	{

		static public string Target(
			
			string link 
			

		)
		{

			IWshRuntimeLibrary.IWshShell shell = new IWshRuntimeLibrary.WshShell();

			IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(link);

			return (shortcut.TargetPath);
		}



	}
}

/*I'll add that if you get an 'Interop type 'IWshRuntimeLibrary.WshShellClass' cannot be embedded. Use the applicable interface instead.' error on compiling, select IWshRuntimeLibrary in your references and set the 'Embed Interop Types' property from True to False. – Jay Riggs May 19 '15 at 23:43*/
