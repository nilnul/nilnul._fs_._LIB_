using System;

namespace nilnul.fs.location_.link_.sym_.file.create_.ret_
{



	/// <summary>
	/// </summary>
	[Obsolete()]
	static public class _SuccessX
	{
		static public bool ExeW(
			nilnul.fs.address_.SpearI src
			,
			nilnul.fs.address_.SpearI target
		)
		{

			//string symbolicLink = @"c:\bar.txt";
			//string fileName = @"c:\tmp\foo.txt";

			//if (System.IO.File.Exists(symbolicLink))
			//{
			//	throw new Exception();
			//}

			////System.IO.File.Create(symbolicLink);

			//_SymX.CreateSymbolicLink(symbolicLink, fileName, _sym.FileOrFolder.File);


#pragma warning disable CS0618 // '_SymX.CreateSymbolicLinkW(string, string, FileOrFolder)' is obsolete: 'not work'
			return _SymX.CreateSymbolicLinkW(
				nilnul.fs.address_.OverLong.Ensure(
					src.ToString()
				)
				,
				nilnul.fs.address_.OverLong.Ensure(
					target.ToString()
				)
				,
				_sym.FileOrFolder.File
			);
#pragma warning restore CS0618 // '_SymX.CreateSymbolicLinkW(string, string, FileOrFolder)' is obsolete: 'not work'
		}



		static public bool Exe(
			string symbolicLink,
			string fileName)
		{

			return ExeW(
				 nilnul.fs.address_.Spear.Parse(symbolicLink),
				 nilnul.fs.address_.Spear.Parse(fileName)

			);
		}




	}
}
