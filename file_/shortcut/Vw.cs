using IWshRuntimeLibrary;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.file_.shortcut
{
	static public class _VwX
	{

		static public string Target(
			
			string shortcut 
			

		)
		{
			Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
			dynamic shell = Activator.CreateInstance(t);

			string target;
			try
			{
				var lnk = shell.CreateShortcut(shortcut);
				try
				{
					target = (string)(lnk.TargetPath);
					return target;

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

			throw new Exception("using Windows Script Host Shell Object to read link, failed.");
		}


		static public string Target(
			
			nilnul.fs.address_.SpearI shortcut 
			

		)
		{
			return Target(shortcut.ToString());
		}

		static public string Target(
			
			nilnul.fs.address_.SpearI1 shortcut 
			

		)
		{
			return Target(shortcut.ToString());
		}


	}
}
