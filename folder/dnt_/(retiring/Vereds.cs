using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.denote_
{
	[Obsolete()]
	public class Vereds
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

		public Vereds(
			nilnul.fs.FolderI folder
		)
		{
			_folder = folder;
		}
		public Vereds(
			nilnul.fs.address_.ShieldI folder
		) : this(
			new nilnul.fs.Folder(folder)
		)
		{
		}

		static public Vereds OvAddress(string address)
		{
			return new Vereds(nilnul.fs.Folder.FroAddress(
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
#pragma warning disable CS0612 // 'Versioned' is obsolete
				x => nilnul.txt.Versioned.IsVersioned(name, x)
#pragma warning restore CS0612 // 'Versioned' is obsolete
			);

		}

		public IEnumerable<FileSystemInfo> getVersionedChild(string prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Where(
#pragma warning disable CS0612 // 'Versioned' is obsolete
				x => nilnul.txt.Versioned.IsVersioned(prefix, x.Name)
#pragma warning restore CS0612 // 'Versioned' is obsolete
			);
		}

#pragma warning disable CS0612 // 'Versioned' is obsolete
		public IEnumerable<nilnul.txt.Versioned> getVersionedChild_retVersioned(string prefix)
#pragma warning restore CS0612 // 'Versioned' is obsolete
		{
#pragma warning disable CS0612 // 'Versioned' is obsolete
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt.Versioned.Parse(x))
#pragma warning restore CS0612 // 'Versioned' is obsolete
				.Where(x => x.prefix == prefix);
		}

		public IEnumerable<nilnul.txt_.Vered> seq(nilnul.txt_._vered_.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.Vered.Parse(x))
				.Where(x => x.name == prefix);
		}

		public IEnumerable<nilnul.txt_.Vered1> seq(nilnul.txt_._vered.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.Vered1.Parse(x))
				.Where(x => x.name == prefix);
		}


		public nilnul.Num getNextChildVer(string prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
#pragma warning disable CS0618 // 'VersionedWithPrefix' is obsolete: '_NamedAsX'
				x => nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix, x)
#pragma warning restore CS0618 // 'VersionedWithPrefix' is obsolete: '_NamedAsX'
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt.Versioned1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
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
#pragma warning disable CS0618 // 'VersionedWithPrefix' is obsolete: '_NamedAsX'
				x => nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix, x)
#pragma warning restore CS0618 // 'VersionedWithPrefix' is obsolete: '_NamedAsX'
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt.Versioned1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
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
			return $"{_folder}{System.IO.Path.DirectorySeparatorChar}{getNextDst(prefix)}";
		}

		public string getNextAddress(string prefix, string ext)
		{
			return $"{_folder}{System.IO.Path.DirectorySeparatorChar}{getNextDst(prefix, ext)}";
		}




#pragma warning disable CS0612 // 'Versioned' is obsolete
		public nilnul.txt.Versioned getLastestVersionedChild_OrNull(string prefix)
#pragma warning restore CS0612 // 'Versioned' is obsolete
		{
#pragma warning disable CS0612 // 'Set' is obsolete
			return nilnul.txt.versioned.Set.GetLatestOrDefault(
#pragma warning restore CS0612 // 'Set' is obsolete

				getVersionedChild_retVersioned(prefix)
				);

		}


















	}
}
