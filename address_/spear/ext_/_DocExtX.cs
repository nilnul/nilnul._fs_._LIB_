using System;
using System.IO;

namespace nilnul.fs.address_.spear.ext_
{
	/// <summary>
	/// retrun the ext of doc
	/// </summary>
	public class _ByPathX
	{

		static public string Txt_assumeSpear(string spear)
		{
			///The extension of the specified path (including the period "."), or null, or Empty. If path is null, GetExtension(String) returns null. If path does not have extension information, GetExtension(String) returns Empty.
			///This method obtains the extension of path by searching path for a period (.), starting with the last character in path and continuing toward the first character. If a period is found before a DirectorySeparatorChar or AltDirectorySeparatorChar character, the returned string contains the period and the characters after it; otherwise, String.Empty is returned.
			///
			///// GetExtension('C:\mydir.old\myfile.ext') returns '.ext'
			// GetExtension('C:\mydir.old\') returns ''
			return System.IO.Path.GetExtension(spear);
		}

		public static string Txt(FileInfo spear)
		{
			return Txt_assumeSpear(spear.FullName);
		}

		static public string Txt(nilnul.fs.address_.SpearI spear)
		{
			return Txt_assumeSpear(spear.ToString());
		}
		static public nilnul.fs._address.doc_._exted.Ext Ext_assumeSpear(string spear)
		{
			return new _address.doc_._exted.Ext(
				Txt_assumeSpear(spear)
			) ;
		}

		static public nilnul.fs._address.doc_._exted.Ext Ext(nilnul.fs.address_.SpearI spear)
		{
			return Ext_assumeSpear(spear.ToString()) ;
		}


	}
}
