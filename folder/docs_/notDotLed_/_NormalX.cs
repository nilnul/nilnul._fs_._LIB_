using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.docs_.notDotLed_
{
	static public class _NonlinkX
	{
		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			return fs.folder.docs_._NotDotLedX.Enumerate(folder).Where(
				x => nilnul.fs.file.be_.Normal.Singleton.be(x)
			);
		}

		static public IEnumerable<FileInfo> AsFileInfoS(DirectoryInfo parent)
		{
			return parent.EnumerateFiles().Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x));
		}

		static public IEnumerable<FileInfo> AsFileInfoS_ofAddress(string parent)
		{
			return AsFileInfoS(new DirectoryInfo(parent));
		}

		static public IEnumerable<FileInfo> AsFileInfoS(nilnul.fs.FolderI parent)
		{
			return nilnul.fs.folder._DocsX.Infos(parent).Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x));

			;
		}


		static public IEnumerable<string> Enumerate(string folderAddress)
		{
			return Enumerate(new DirectoryInfo(folderAddress));
		}




		public static IEnumerable<nilnul.fs._address.DocI> Enumerate(nilnul.fs.FolderI folder)
		{
			return Enumerate(folder.ToString()).Select(x => new _address.Doc(x));
		}

		public static IEnumerable<string> EnumerateAsAddress(nilnul.fs.FolderI folder)
		{
			return System.IO.Directory.EnumerateFiles(folder.ToString()).Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x));
		}


		public static IEnumerable<string> _AddressTxts_ofFolderAddress(string _folder)
		{
			return System.IO.Directory.EnumerateFiles(_folder).Where(x => nilnul.fs.file.be_.Normal.Singleton.be(x));
		}





	}
}
