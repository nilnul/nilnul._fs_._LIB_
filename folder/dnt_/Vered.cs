using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.denote_
{
	public class Vered
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI _folder
;
		public nilnul.fs.FolderI folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Vered(
			nilnul.fs.FolderI folder
		)
		{
			_folder = folder;
		}
		public Vered(
			nilnul.fs.Folder folder
		) : this((FolderI)folder)
		{
		}

		public Vered(nilnul.fs.address_.ShieldI shield) : this(new nilnul.fs.Folder(shield))
		{

		}

		static public Vered OvAddress(string address)
		{
			return new Vered(nilnul.fs.Folder.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo dirInfo
		{
			get { return new DirectoryInfo(_folder.ToString()); }
		}



		public IEnumerable<string> getVersionedNames(string name)
		{
			return new DirectoryInfo(this.folder.ToString()).EnumerateFileSystemInfos().Select(x => x.Name).Where(
				x => nilnul.txt.Versioned.IsVersioned(name, x)
			);

		}

		public IEnumerable<FileSystemInfo> getVersionedChild(string prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Where(
				x => nilnul.txt.Versioned.IsVersioned(prefix, x.Name)
			);
		}

		[Obsolete(nameof(Vereds.seq))]
		public IEnumerable<nilnul.txt.Versioned> getVersionedChild_retVersioned(string prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt.Versioned.Parse(x))
				.Where(x => x.prefix == prefix);
		}
		public nilnul.Num getNextChildVer(string prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix, x)
			)
			.Select(
				x => nilnul.txt.Versioned1.Parse(x)
			)
			.Select(x => (nilnul.Num)x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}

		public nilnul.Num getNextChildVer(string prefix, string ext)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(x => x.EndsWith($".{ext}"))
			.Select(
				x => x.Substring(0, x.Length - $".{ext}".Length)
			)
			.Where(
				x => nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix, x)
			)
			.Select(
				x => nilnul.txt.Versioned1.Parse(x)
			)
			.Select(x => new nilnul.Num(x.version));
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}



		public string getNextDst(string prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(getNextChildVer(prefix))}";
		}

		public DirectoryInfo createNextDir(string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				getNextAddress(prefix)
			);
		}

		public StreamWriter createNextTxtAppendStream(string prefix)
		{
			return System.IO.File.AppendText(
				getNextAddress(prefix, "txt")
			);
		}


		public string getNextDst(string prefix, string ext)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(getNextChildVer(prefix, ext))}.{ext}";
		}


		public string getNextAddress(string prefix)
		{
			return $"{_folder}{getNextDst(prefix)}";
		}

		public string getNextAddress(string prefix, string ext)
		{
			return $"{_folder}{getNextDst(prefix, ext)}";
		}




		public nilnul.txt.Versioned getLastestVersionedChild_OrNull(string prefix)
		{
			return nilnul.txt.versioned.Set.GetLatestOrDefault(

				getVersionedChild_retVersioned(prefix)
				);


		}


















	}
}
