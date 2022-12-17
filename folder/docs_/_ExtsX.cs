using nilnul.fs.folder.to_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.docs_
{
	static public class _ExtsX
	{
		public static IEnumerable<nilnul.fs._address._dst.Denote> Denotes(nilnul.fs.FolderI folder, nilnul.fs._address.denote_._exted.ext.Set ext)
		{
			return nilnul.fs.folder._DocsX.Denotes(folder).Where(x => ext.Contains( nilnul.fs._address.doc_.exted._ExtX._Ext(x) ));

		}
		static public IEnumerable<string> Captions(DirectoryInfo folder, nilnul.fs._address.denote_._exted.ext.Set ext)
		{
			return nilnul.fs.folder._DocsX.Names(folder).Where(x => ext.Contains( nilnul.fs._address.doc_.exted._ExtX._Ext(x) ));
		}

		static public IEnumerable<string> Captions(nilnul.fs.FolderI folder, nilnul.fs._address.denote_._exted.ext.Set ext)
		{
			return Captions(folder.To(), ext);
		}


		static public IEnumerable<string> Captions_ofAddress(string folderAddress, nilnul.fs._address.denote_._exted.ext.Set ext)
		{
			return Captions(new DirectoryInfo(folderAddress), ext);
		}


		public static IEnumerable<nilnul.fs.address_.spear_.ParentDoc> Spears(nilnul.fs.FolderI folder, nilnul.fs._address.denote_._exted.ext.Set ext)
		{
			return Denotes(folder, ext).Select(x =>new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, x) );
		}

		public static IEnumerable<nilnul.fs.address_.spear_.ParentDoc> Spears(nilnul.fs.FolderI folder, params string[] ext)
		{
			return Spears(folder, new _address.denote_._exted.ext.Set(ext));
		}

		public static IEnumerable<nilnul.fs.address_.spear_.ParentDoc> Spears_ofAddress(string attachPath, params string[] v1)
		{

			return Spears(
				nilnul.fs.Folder.FroAddress(attachPath)
				,
				v1

			);
		}


	}
}
