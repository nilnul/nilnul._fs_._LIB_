using IWshRuntimeLibrary;


namespace nilnul.fs.file_._shortcut.create_
{
	/// <summary>
	/// documents in the same base
	/// </summary>
	static public class _BasedX
	{
		public const string DESCRIPTION = "deleted;shortcut to a same blob";
		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				string src
				,
				string target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			Create(container
				,
				nilnul.fs._address.Document.Parse(src)
				,
				nilnul.fs._address.Document.Parse(target)
				,
				 description = DESCRIPTION
				,
				 hotkey = null

				);
		}

		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				string src
				,
				nilnul.fs._address.DocumentI target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{

			Create(
				container
				,
				nilnul.fs._address.Document.Parse(src)
				,
				target
				,
				description
				,
				hotkey
			);
		}
		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				nilnul.fs._address.DocumentI src
				,
				nilnul.fs._address.DocumentI target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			//For .Net 4.0 and above, replace the first line with the following (Thanks to Millie Smith!):
			//WshShell wsh = new WshShell();
			WshShell shell = new WshShell();

			string shortcutAddress = new nilnul.fs.address_.spear_.ParentDocument(
				container,
				 nilnul.fs._address.Document.Parse(
					src.ToString() + "." +
					"lnk"
				)

			).ToString();

			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

			shortcut.Description = description;
			if (hotkey != null)
			{
				shortcut.Hotkey = hotkey;// "Ctrl+Shift+N";

			}
			shortcut.TargetPath = new nilnul.fs.address_.spear_.ParentDocument(
				container,
				target
			).ToString()
			;

			//shortcut.Arguments = "c:\\app\\settings1.xml";
			//// not sure about what this is for
			//shortcut.WindowStyle = 1;
			//shortcut.WorkingDirectory = "c:\\app";
			//shortcut.IconLocation = "specify icon location";

			shortcut.Save();
		}




	}
}
