namespace nilnul.fs.file_.shortcut_.relative_.cmdStart
{
	static public class _CreateX
	{


		static public void Create(
			nilnul.fs.address_.spear_.ParentDoc link,
			nilnul.fs._address.div.co._relPath.Ret relPath
		)
		{
			shortcut._CreateX.Create(
				link.parent
				,
				new _address.doc_._exted.Main(
					link.doc.denote
				)
				,
				relPath.ToString()


			);
		}

		static public void Create(
			nilnul.fs.address_.ShieldI shield
			,
			_address.doc_._exted.Main main
			,
			nilnul.fs._address.div.co._relPath.Ret relPath
		)
		{
			shortcut._CreateX.Create(
				shield
				,
				main
				,
				//$@"%windir%\system32\cmd.exe /c start """" ""%CD%\bat\bat\run.bat"""
				//%COMSPEC%
				$@"%COMSPEC% /c start """" ""{relPath.ToString()}"""
			///C causes the console to close itself after it executes the command.

			//$@"%windir%\system32\cmd.exe /c start """" ""{relPath.ToString()}"""
			/*
To create a shortcut with a relative path, set the target to the following.

%windir%\system32\cmd.exe /c start your_relpath\app.exe [your_args]
It is also straightforward to make the program run as administrator.

Properties > Advanced > Run as administrator*/
			);
		}


	}
}
