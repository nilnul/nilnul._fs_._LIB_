using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.docs_
{
	/// <summary>
	/// excluding ".a" or the like
	/// </summary>
	static public class _NotDotLedX
	{
		/// <summary>
		/// avoid repeating same code; increase throughput of a method
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public bool IsNotDotLed_ofDoc(string s) {
			return !s.StartsWith(".");
		}
		static public IEnumerable<FileInfo> AsFileInfoS(DirectoryInfo parent)
		{
			return parent.EnumerateFiles().Where(
				x => IsNotDotLed_ofDoc(x.Name)
			);
		}
		static public IEnumerable<string> Enumerate(DirectoryInfo folder)
		{
			return folder.EnumerateFiles().Select(
				x=>x.Name
			).Where(
				x => IsNotDotLed_ofDoc(x)
			);
		}


		static public IEnumerable<FileInfo> AsFileInfoS_ofAddress(string parent)
		{
			return AsFileInfoS(new DirectoryInfo(parent));
		}

		static public IEnumerable<FileInfo> AsFileInfoS(nilnul.fs.FolderI parent)
		{
			return AsFileInfoS(
				nilnul.fs.folder.to_._InfoX.To(parent)
			);

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

		public static IEnumerable<string> EnumerateAsAddresses(nilnul.fs.FolderI folder)
		{
			return AsFileInfoS(folder).Select(x=>x.FullName);
		}


		public static IEnumerable<string> _Addresses_folderOfAddress(string _folder)
		{
			return AsFileInfoS_ofAddress(_folder).Select(x=>x.FullName);
		}





	}
}
