using nilnul.fs.folder.to_;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.documents_
{
	static public class _ByExtX
	{
		static public IEnumerable<fs._address.DocumentI> Documents(DirectoryInfo folder, string ext)
		{
			return nilnul.fs.folder._DocumentsX.Documents(folder).Where(x => new nilnul.fs._address.document.be_.Ext(ext).be(x));
		}

		

		static public IEnumerable<FileInfo> Infos_bySearch(System.IO.DirectoryInfo folder, string ext)
		{
			return folder.EnumerateFiles($"*{ext}", SearchOption.AllDirectories);
		}

		static public IEnumerable<_address.DocumentI> Documents_ofAddress(string folderAddress, string ext)
		{
			return Documents(new DirectoryInfo(folderAddress), ext);
		}

		public static IEnumerable<nilnul.fs._address.DocumentI> Documents(nilnul.fs.FolderI folder, string ext)
		{
			return nilnul.fs.folder._DocumentsX.Documents(folder).Where(x => new nilnul.fs._address.document.be_.Ext(ext).be(x));
			
		}
	}
}
