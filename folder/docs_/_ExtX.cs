using nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_.nonempty_.ovAftDot_;
using nilnul.fs.folder.to_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.docs_
{
	static public class _ExtX
	{
		static public IEnumerable<string> Denotes(DirectoryInfo folder, string ext)
		{
			return nilnul.fs.folder._DocsX.Names(folder).Where(x => new nilnul.fs._address.doc.be_.Ext(ext).be(x));
		}

		static public IEnumerable<string> Captions(DirectoryInfo folder, string ext)
		{
			return nilnul.fs.folder._DocsX.Captions(folder).Where(x => new nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext(ext).be(x));
		}

		public static IEnumerable<string> Denotes(DirectoryInfo folder, _address._route.division_._div._dir.dnt_._exted.ExtI singleton)
		{
			return nilnul.fs.folder._DocsX.Names(folder).Where(
				x =>new nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext(singleton).be(x)
			);

			
		}

		static public IEnumerable<string> Denotes(nilnul.fs.FolderI folder, string ext)
		{
			return Denotes(folder.To(), ext);
		}

		static public IEnumerable<string> Captions(nilnul.fs.FolderI1 folder, string ext)
		{
			return Captions(nilnul.fs.folder.op_.to_._InfoX.To(folder), ext);
		}

		static public IEnumerable<string> Captions(nilnul.fs.address_.ShieldI1 folder, string ext)
		{
			return Captions(nilnul.fs.address_.shield.to_._InfoX.Info(folder), ext);
		}

		static public IEnumerable<string> Denotes_ofAddress(string folderAddress, string ext)
		{
			return Denotes(new DirectoryInfo(folderAddress), ext);
		}
		static public IEnumerable<string> Captions_ofAddress(string folderAddress, string ext)
		{
			return Captions(new DirectoryInfo(folderAddress), ext);
		}


		public static IEnumerable<nilnul.fs._address.DocI> Docs(nilnul.fs.FolderI folder, string ext)
		{
			return Denotes(folder, ext).Select(x => new nilnul.fs._address.Doc(x));
		}
		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Docs(nilnul.fs.FolderI1 folder, string ext)
		{
			return Captions(folder, ext).Select(x => new nilnul.fs._address._route.division_._div._dir.Dnt(x));
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Docs(nilnul.fs.address_.ShieldI1 folder, string ext)
		{
			return Captions(folder, ext).Select(x => new nilnul.fs._address._route.division_._div._dir.Dnt(x));
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Docs_folderOfAddress(string folder, string ext)
		{
			return Docs(nilnul.fs.Folder1.FroAddress(folder),ext);
		}


	}
}
