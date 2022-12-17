using nilnul.fs.folder.to_;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.docs_.ext_
{
	static public class _LnkX
	{
		static public IEnumerable<string> Captions(DirectoryInfo folder)
		{
			return fs.folder.docs_._ExtX.Denotes(
				folder
				,
				fs._address._route.division_._div._dir.dnt_._exted.ext_.nonempty_.ovAftDot_.Lnk.Singleton
				
			);
		}

		static public IEnumerable<string> Captions(nilnul.fs.FolderI folder)
		{
			return Captions(folder.To());
		}

		static public IEnumerable<string> Captions(nilnul.fs.Folder folder)
		{
			return Captions(folder.To());
		}

		static public IEnumerable<string> Captions(nilnul.fs.address_.ShieldI folder)
		{
			return Captions(new nilnul.fs.Folder(folder) );
		}

		static public IEnumerable<string> Captions_ofAddress(string folderAddress)
		{
			return Captions(new DirectoryInfo(folderAddress));
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Dnts(nilnul.fs.FolderI folder)
		{
			return Captions(folder).Select(x => new nilnul.fs._address._route.division_._div._dir.Dnt(x));
		}
		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Dnts(nilnul.fs.Folder folder)
		{
			return Dnts((FolderI)folder);
		}

		public static IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Dnts(nilnul.fs.address_.ShieldI folder)
		{
			return Dnts(new Folder(folder) );
		}

		public static IEnumerable<nilnul.fs._address.DocI> Docs(nilnul.fs.FolderI folder)
		{
			return Captions(folder).Select(x => new nilnul.fs._address.Doc(x));
		}

	}
}
