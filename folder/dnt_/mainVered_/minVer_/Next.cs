using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using nilnul.fs._address.doc_._exted;

namespace nilnul.fs.folder.dnt_.mainVered_.minVer_
{
	public class Next
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI1 _parent
;
		public nilnul.fs.FolderI1 parent
		{
			get => _parent;
			set => _parent = parent;
		}

		public Next(
			nilnul.fs.FolderI1 folder
		)
		{
			_parent = folder;
		}

		public Next(
			nilnul.fs.address_.ShieldI1 parent
		) : this(
			new nilnul.fs.Folder1(parent)
		)
		{

		}

		public static Next OvAddress(string address)
		{
			return new Next(nilnul.fs.Folder1.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo parentAsInfo => new DirectoryInfo(_parent.ToString());


		/// <summary>
		/// gurantee the main's version is the smallest we get
		/// </summary>
		/// <param name="main"></param>
		/// <param name="ext"></param>
		/// <returns></returns>
		internal nilnul.NumI1 _ver(
			nilnul.txt_.Vered2 main
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			IEnumerable<Num1> s = parentAsInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Select(x => nilnul.fs._address.doc_.MainExt.Parse(x))
			.Where(

				x =>
				nilnul.fs._address.doc_._exted.ext.Eq.Singleton.Equals(
					x.ext
					,
					//.EndsWith($".{ext}")
					ext
				)
			)
			.Select(
				x => nilnul.txt_.Vered1.Parse(x.main.ToString())//.Substring(0, x.Length -$".{ext}".Length)	
			)
			.Where(
				x =>
				nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
					x.name.ToString(), main.name
				)
			//x=>nilnul.txt_.vered.be_._NamedAsX.Be(prefix,x.ToString()) 
			)
			//.Select(
			//	x => nilnul.txt.Versioned1.Parse(x)
			//)
			.Select(x => new nilnul.Num1(x.version));
			if (s.Any())
			{
				return new nilnul.Num1(
					//nilnul.num.set_.sed.str_.started._MaxX.Eval(
					nilnul.nums_.started._MaxX._Eval(
						s.Select(x => new nilnul.Num(x.toBigint()))
					)
					+
					(nilnul.Num)1
				);
			}
			return main.version;
		}



		private nilnul.NumI1 _ver(Main main, _address.doc_._exted.ExtI ext)
		{
			return _ver(nilnul.txt_.Vered2.Parse(main), ext);
		}



		public string denote(
			nilnul.fs._address.doc_._exted.Main main
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			return $"{ nilnul.txt_.vered._KeyX._Txt(main)}{ nilnul.num.phrase_._DecX.Phrase( _ver(main, ext) )}{ext}";
		}


		public string denote(nilnul.fs._address.doc_.MainExt doc)
		{
			return denote(doc.main, doc.ext);
		}



		public string denote(
		nilnul.fs._address.DocI doc)
		{
			return denote(
				 nilnul.fs._address.doc_.MainExt.Ov(doc)

			);
		}

		public string denote(string doc)
		{
			return denote(_address.doc_.MainExt.Parse(doc));
		}


		private object denote(string prefix, _address.doc_._exted.ExtI ext)
		{
			return denote(
				new nilnul.fs._address.doc_.MainExt(prefix, ext)
			);
		}

		public string denote(string prefix, string ext)
		{
			return denote(
				new nilnul.fs._address.doc_.MainExt(prefix, ext)
			);

			//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		}

		public string address(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return $"{_parent}{denote(prefix, ext)}";
		}


		public string address(string prefix, string ext)
		{
			return $"{_parent}{denote(prefix, ext)}";
		}

		public string address(string doc)
		{
			return $"{_parent}{denote(doc)}";
		}




	}
}
