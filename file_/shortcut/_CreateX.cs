using IWshRuntimeLibrary;

namespace nilnul.fs.file_.shortcut
{
	static public class _CreateX
	{

		static public void Create(
			nilnul.fs.address_.ShieldI container
			,
			nilnul.fs._address.doc_._exted.Main main2bCreated
			,
			string target
			,
			string arguments = null
			,
			string workingDir = null
			,
			string description = ""
			,
			string hotkey = null

		)
		{
			//For .Net 4.0 and above, replace the first line with the following (Thanks to Millie Smith!):
			//WshShell wsh = new WshShell();

			WshShell shell = new WshShell();
			string shortcutAddress = System.IO.Path.Combine(container.ToString(), $@"{main2bCreated}.lnk");
			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
			shortcut.Description = description;
			if (hotkey != null)
			{
				shortcut.Hotkey = hotkey;// "Ctrl+Shift+N";
			}
			shortcut.TargetPath = target;

			shortcut.Arguments = arguments;// "c:\\app\\settings1.xml";
										   //// not sure about what this is for
										   //shortcut.WindowStyle = 1;

			shortcut.WorkingDirectory = workingDir;
			//shortcut.IconLocation = "specify icon location";

			shortcut.Save();
		}



	}
}
/*
 If you are using csc.exe instead of Visual Studio, to add a reference to the Windows Script Host Object Model, you have to:

Use the tlbimp.exe tool to create a managed assembly:

tlbimp.exe c:\windows\system32\wshom.ocx /out:IWshRuntimeLibrary.dll

Reference the .dll using the /r switch in csc.exe:

csc.exe Lnk.cs /r:IWshRuntimeLibrary.dll
 */