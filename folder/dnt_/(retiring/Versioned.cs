using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.slider.to;
using nilnul.txt;
using nilnul.str;
using nilnul.str_.started;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.fs.folder.dsts
{
	[Obsolete()]
	public class Ver
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.location_.Folder _folder
;
		public nilnul.fs.location_.Folder folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Ver(
			nilnul.fs.location_.Folder folder
		)
		{
			_folder = folder;
		}


		public Ver(string address) : this(
			new location_.Folder(
			address)

			)
		{
		}



		public DirectoryInfo	dirInfo
		{
			get { return new DirectoryInfo(_folder.ToString()); }
		}



		public IEnumerable<string> getVersionedNames(string prefix)
		{
			return new DirectoryInfo(this.folder.ToString()).EnumerateFileSystemInfos().Select(x => x.Name).Where(
				x => nilnul.txt.Versioned.IsVersioned(prefix, x)
			);

		}

		public IEnumerable<FileSystemInfo> getVersionedChild(string prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Where(
				x => nilnul.txt.Versioned.IsVersioned(prefix, x.Name)
			);
		}

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
				x=>nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix,x) 
			)
			.Select(
				x => nilnul.txt.Versioned1.Parse(x)
			)
			.Select(x =>  (nilnul.Num) x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}

		public nilnul.Num getNextChildVer(string prefix,string ext)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(x=> x.EndsWith($".{ext}") )
			.Select(
				x=>x.Substring(0, x.Length -$".{ext}".Length)	
			)
			.Where(
				x=>nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix,x) 
			)
			.Select(
				x => nilnul.txt.Versioned1.Parse(x)
			)
			.Select(x =>  new nilnul.Num( x.version));
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}



		public string getNextDst(string prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(getNextChildVer(prefix))}";
		}

		public DirectoryInfo createNextDir(string prefix) {
			return System.IO.Directory.CreateDirectory(
				getNextAddress(prefix)
			);
		}

		public StreamWriter createNextTxtAppendStream(string prefix) {
			return System.IO.File.AppendText(
				getNextAddress(prefix,"txt")
			);
		}


		public string getNextDst(string prefix,string ext)
		{
			return getNextDst(nilnul.txt_._nameVer_.Name.CreateByAppendingUnderscoreIfNecessary(prefix));
		}


		public string getNextDst(nilnul.txt_._nameVer_.Name prefix,string ext)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(getNextChildVer(prefix,ext))}.{ext}";
		}



		public string getNextAddress(string prefix)
		{
			return $"{_folder}{System.IO.Path.DirectorySeparatorChar}{getNextDst(prefix)}";
		}

		public string getNextAddress(string prefix,string ext)
		{
			return $"{_folder}{System.IO.Path.DirectorySeparatorChar}{getNextDst(prefix,ext)}";
		}


		

		public nilnul.txt.Versioned getLastestVersionedChild_OrNull(string prefix)
		{
			return nilnul.txt.versioned.Set.GetLatestOrDefault(

				getVersionedChild_retVersioned(prefix)
				);


		}


	

		













	}
}
