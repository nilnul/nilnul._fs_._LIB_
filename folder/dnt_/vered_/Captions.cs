using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dst_.vered_
{
	public class Captions
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI _parent
;
		public nilnul.fs.FolderI parent
		{
			get { return _parent; }
			set
			{
				_parent = parent;
			}
		}

		public Captions(
			nilnul.fs.FolderI folder
		)
		{
			_parent = folder;
		}

		static public Captions OvAddress(string address)
		{
			return new Captions(nilnul.fs.Folder.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo parentAsInfo
		{
			get { return new DirectoryInfo(_parent.ToString()); }
		}



		public IEnumerable<string> dstNameS_ofCaption(string name)
		{
			return new DirectoryInfo(this.parent.ToString()).EnumerateFileSystemInfos().Select(x => x.Name).Where(
#pragma warning disable CS0612 // 'Versioned' is obsolete
				x => nilnul.txt.Versioned.IsVersioned(name, x)
#pragma warning restore CS0612 // 'Versioned' is obsolete
			);

		}

		public IEnumerable<FileSystemInfo> infos_ofCaption(string prefix)
		{
			return parentAsInfo.EnumerateFileSystemInfos().Where(
#pragma warning disable CS0612 // 'Versioned' is obsolete
				x => nilnul.txt.Versioned.IsVersioned(prefix, x.Name)
#pragma warning restore CS0612 // 'Versioned' is obsolete
			);
		}

#pragma warning disable CS0612 // 'Versioned' is obsolete
		public IEnumerable<nilnul.txt.Versioned> vered_ofCaption(string prefix)
#pragma warning restore CS0612 // 'Versioned' is obsolete
		{
#pragma warning disable CS0612 // 'Versioned' is obsolete
			return parentAsInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt.Versioned.Parse(x))
#pragma warning restore CS0612 // 'Versioned' is obsolete
				.Where(x => x.prefix == prefix);
		}
		public nilnul.Num nextVer_ofCaption(string prefix)
		{
			var s = parentAsInfo.EnumerateFileSystemInfos().Select(
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

		//public nilnul.Num getNextChildVer(string prefix,string ext)
		//{
		//	var s = dirInfo.EnumerateFileSystemInfos().Select(
		//		x => x.Name
		//	)
		//	.Where(x=> x.EndsWith($".{ext}") )
		//	.Select(
		//		x=>x.Substring(0, x.Length -$".{ext}".Length)	
		//	)
		//	.Where(
		//		x=>nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix,x) 
		//	)
		//	.Select(
		//		x => nilnul.txt.Versioned1.Parse(x)
		//	)
		//	.Select(x =>  new nilnul.Num( x.version));
		//	if (s.Any())
		//	{
		//		return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
		//	}
		//	return (nilnul.Num)0;
		//}



		public string nextDst_ofCaption(string prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer_ofCaption(prefix))}";
		}

		public DirectoryInfo nextDirInfo_ofCaption(string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				nextAddress_ofCaption(prefix)
			);
		}

		//public StreamWriter createNextTxtAppendStream(string prefix) {
		//	return System.IO.File.AppendText(
		//		getNextAddress(prefix,"txt")
		//	);
		//}


		//public string getNextDst(string prefix,string ext)
		//{
		//	return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(getNextChildVer(prefix,ext))}.{ext}";
		//}


		public string nextAddress_ofCaption(string prefix)
		{
			return $"{_parent}{System.IO.Path.DirectorySeparatorChar}{nextDst_ofCaption(prefix)}";
		}

		//public string getNextAddress(string prefix,string ext)
		//{
		//	return $"{_folder}{System.IO.Path.DirectorySeparatorChar}{getNextDst(prefix,ext)}";
		//}

#pragma warning disable CS0612 // 'Versioned' is obsolete
		public nilnul.txt.Versioned lastVeredOrNul_ofCaption(string prefix)
#pragma warning restore CS0612 // 'Versioned' is obsolete
		{
#pragma warning disable CS0612 // 'Set' is obsolete
			return nilnul.txt.versioned.Set.GetLatestOrDefault(
#pragma warning restore CS0612 // 'Set' is obsolete
				vered_ofCaption(prefix)
				);
		}
	}
}
