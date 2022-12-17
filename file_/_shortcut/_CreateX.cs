using IWshRuntimeLibrary;
using System;

namespace nilnul.fs.file_._shortcut
{
	static public class _CreateX
	{

		static public void Create(
			nilnul.fs.AddressI target
			,
			nilnul.fs.address_.ShieldI container
			,
			nilnul.fs._address.doc_._exted.Main main2bCreated

			, string description = ""
			, string hotkey = null

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
			shortcut.TargetPath = target.ToString();

			//shortcut.Arguments = "c:\\app\\settings1.xml";
			//// not sure about what this is for
			//shortcut.WindowStyle = 1;
			//shortcut.WorkingDirectory = "c:\\app";
			//shortcut.IconLocation = "specify icon location";

			shortcut.Save();
		}

		static void CreateInDesktop(
			nilnul.fs.address_.ShieldI container
			,
			nilnul.fs._address.doc_._exted.Main main

		)
		{
			object shDesktop = (object)"Desktop";
			WshShell shell = new WshShell();
			string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Notepad.lnk";
			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
			shortcut.Description = "New shortcut for a Notepad";
			shortcut.Hotkey = "Ctrl+Shift+N";
			shortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\notepad.exe";
			shortcut.Save();
		}


	}
}
