using nilnul.fs.file;
using nilnul.fs.folder.to_;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace nilnul.fs.folder.docs_.ext.as_
{
	static public class _InfosX
	{


		static public IEnumerable<FileInfo> Infos(DirectoryInfo parent, string ext)
		{
			return parent.EnumerateFiles().Where(x => new nilnul.fs.file.be_.Ext(ext).Be(x));
		}

		static public IEnumerable<FileInfo> Infos_ofAddress(string parent, string ext)
		{
			return Infos(new DirectoryInfo(parent), ext);
		}

		static public IEnumerable<FileInfo> Infos(nilnul.fs.FolderI parent, string ext)
		{
			return Infos(parent.To(), ext);
		}


		public static IEnumerable<string> Addresses(nilnul.fs.FolderI folder, string ext)
		{
			return Infos(folder, ext).Select(x => x.FullName);
		}


		public static IEnumerable<string> Addresses_ofFolderAddress(string _folder, string ext)
		{
			return Addresses(
				nilnul.fs.Folder.FroAddress(_folder)
				,
				ext
			);
		}





	}
}
