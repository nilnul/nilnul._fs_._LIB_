using System;
using System.Diagnostics;

namespace nilnul.fs._address._route.division_.div_.directory.op_.of_
{
	static public class _DestinationX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentOrDirectory"></param>
		/// <returns></returns>
		static public _address.DirectoryI Old(_address. DestinationI documentOrDirectory)
		{
			switch (documentOrDirectory)
			{
				case _address. DirectoryI directory:
					return (directory);
				case DocumentI document:
					return _address.directory_._DocumentX.Exe(document);
				default:
					return Old(nilnul.fs._address.DestinationA.Parse(documentOrDirectory.ToString()));
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}


		static public  _address.DirectoryI Old(string division)
		{
			return Old(
				nilnul.fs._address.DestinationA.Parse(division)
			);
		}
		//[Conditional("DEBUG")]

		[Obsolete(nameof(nilnul.txt.op_.unary_.fs_.EnsureEndWithDirSep))]
		static public  string EnsureEndDeck(string division)
		{
			return  nilnul.txt.op_.unary_.fs_.EnsureEndWithDirSep.Singleton.op(division) ;
		}

		
	}
}
