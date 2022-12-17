using IWshRuntimeLibrary;


namespace nilnul.fs.file_._shortcut.create_
{
	static public class _InSameFolderX
	{
		public const string DESCRIPTION = "deleted;shortcut to a same blob";
		static public void Create(
			nilnul.fs.address_.SpearI src

			//,
			//nilnul.fs._address.doc_._dotted.Main main
			,
			nilnul.fs._address.Doc target
			,

			string description = DESCRIPTION
			, string hotkey = null

		)
		{
			Create(src, (_address.DocI)target, DESCRIPTION, hotkey);
		}
		static public void Create(
			nilnul.fs.address_.SpearI src

			//,
			//nilnul.fs._address.doc_._dotted.Main main
			,
			nilnul.fs._address.DocI target
			,

			string description = DESCRIPTION
			, string hotkey = null

		)
		{
			var containerDoc = new nilnul.fs.address_.spear_.ParentDoc(src);
			Create(
				containerDoc.parent
				,
				containerDoc.doc
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
				string src
				,
				nilnul.fs._address.DocI target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{

			Create(
				container
				,
				new _address.Doc(src)
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
				nilnul.fs._address.DocI src
				,
				nilnul.fs._address.DocI target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			//For .Net 4.0 and above, replace the first line with the following (Thanks to Millie Smith!):
			//WshShell wsh = new WshShell();
			WshShell shell = new WshShell();

			string shortcutAddress = new nilnul.fs.address_.spear_.ParentDoc(
				container,
				new nilnul.fs._address.doc_.exted_.Dotted(
					src.ToString()
					,
					"lnk"
				)

			).ToString();
			//file  
			//System.IO.Path.Combine( 
			//	nilnul.fs.address_.element_._ContainerDocX.Container( src).ToString() , 
			//	$@"{src.sprig.document.doc}.lnk"
			//);

			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

			shortcut.Description = description;
			if (hotkey != null)
			{
				shortcut.Hotkey = hotkey;// "Ctrl+Shift+N";

			}
			shortcut.TargetPath = new nilnul.fs.address_.spear_.ParentDoc(
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

		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				nilnul.fs._address.DocI src
				,
				nilnul.fs._address.Doc target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			Create(container, src, (_address.DocI)target, description, hotkey);
		}
		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				nilnul.fs._address.Doc src
				,
				nilnul.fs._address.DocI target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			Create(container, (_address.DocI)src, target, description, hotkey);
		}

		static public void Create(
				nilnul.fs.address_.ShieldI container
				,
				nilnul.fs._address.Doc src
				,
				nilnul.fs._address.Doc target
				,
				string description = DESCRIPTION
				,
				string hotkey = null
			)
		{
			Create(container, (_address.DocI)src, (_address.DocI)target, description, hotkey);
		}


		static public void Create(
			string file

			//,
			//nilnul.fs._address.doc_._dotted.Main main
			,
			string target
			,

			string description = "deleted;shortcut to a same blob"
			, string hotkey = null

		)
		{

			Create(
				nilnul.fs.address_.Spear.Parse(file)
				,
				new _address.Doc(target)
				,
				description
				,
				hotkey
			);
		}



	}
}
