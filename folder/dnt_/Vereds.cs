using nilnul.fs._address;
using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dnt_
{
	public class Vereds1
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI1 _folder
;
		public nilnul.fs.FolderI1 folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Vereds1(
			nilnul.fs.FolderI1 folder
		)
		{
			_folder = folder;
		}
		public Vereds1(
			nilnul.fs.Folder1 folder
		):this((nilnul.fs.FolderI1)folder)
		{
			//_folder = folder;
		}

		public Vereds1(
			DirectoryInfo folder
		) : this(
			new nilnul.fs.Folder1(folder)
		)
		{
		}
		public Vereds1(
			nilnul.fs.address_.ShieldI1 folder
		) : this(
			new nilnul.fs.Folder1(folder)
		)
		{
		}

		static public Vereds1 OvAddress(string address)
		{
			return new Vereds1(nilnul.fs.Folder1.FroAddress(
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

		internal IEnumerable<Vered2> seq(DocI doc)
		{
			return seq(
				 nilnul.txt_.Vered2.Parse(doc.ToString())
			);
		}

		internal IEnumerable<Vered2> seq(DntI doc)
		{
			return seq(
				 nilnul.txt_.Vered2.Parse(doc.ToString())
			);
		}


		internal IEnumerable<Vered2> seq(_address._route.division_._div._dir.DntI doc)
		{
			return seq(
				 nilnul.txt_.Vered2.Parse(doc.ToString())
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

		public IEnumerable<nilnul.txt_.Vered2> seq(nilnul.txt_._vered.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.Vered2.Parse(x))
				.Where(x => x.name == prefix);
		}


		public IEnumerable<nilnul.txt_.vered_.veR_.Dec> seqAsDecs(nilnul.txt_._vered.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.vered_.veR_.Dec.Parse(x))
				.Where(x => x.nom == prefix);
		}

		public IEnumerable<nilnul.txt_.Vered3> seq1(nilnul.txt_._vered.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.Vered3.Parse(x))
				.Where(x => x.nom == prefix);
		}

		//public IEnumerable<Vered2> seq(nilnul.txt_._vered.Name v)
		//{

		//}


		public IEnumerable<nilnul.txt_.Vered2> seq_ofNom(string prefix)
		{
			return seq(new nilnul.txt_._vered.Name(prefix) );
		}

		public IEnumerable<nilnul.txt_.Vered2> seq(nilnul.txt_.Vered2 prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Select(x => x.Name).Select(x => nilnul.txt_.Vered2.Parse(x))
				.Where(
				x => x.name == prefix.name
				&&
				x.version.toBigint().en>=prefix.num.toBigint().en
			);
		}

	


		public nilnul.Num1 getNextChildVer(string prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x)
			)
			.Select(
				x => nilnul.txt_.Vered2.Parse(x)
			)
			.Select(x => x.version);
			if (s.Any())
			{
				return nilnul.num.op_.binary_.max.Cascade.Singleton.cascade(s) + (nilnul.Num1)1;
				//return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num1)0;
		}

		public nilnul.Num1 getNextChildVer(string prefix, string ext)
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
			.Select(x => new nilnul.Num1(x.version));
			if (s.Any())
			{
				return nilnul.num.op_.binary_.max.Cascade.Singleton.cascade(s) + (nilnul.Num1)1;

				//return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num1)1;
			}
			return (nilnul.Num1)0;
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




		public nilnul.txt.Versioned getLastestVersionedChild_OrNull(string prefix)
		{
			return nilnul.txt.versioned.Set.GetLatestOrDefault(

				getVersionedChild_retVersioned(prefix)
				);

		}


















	}
}
