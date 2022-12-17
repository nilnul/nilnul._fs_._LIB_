using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.doc_.exted_.vered_
{
	//[Obsolete(nameof(denote_.mainVered_.minVer_.Next))]
	public class Newest
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI _parent
;
		public nilnul.fs.FolderI parent
		{
			get => _parent;
			set => _parent = parent;
		}

		public Newest(
			nilnul.fs.FolderI folder
		)
		{
			_parent = folder;
		}


		public Newest(
			nilnul.fs.address_.ShieldI parent
		) : this(
			new nilnul.fs.Folder(parent)
		)
		{

		}

		public static Newest OvAddress(string address)
		{
			return new Newest(nilnul.fs.Folder.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo parentAsInfo => new DirectoryInfo(_parent.ToString());

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix"></param>
		/// <param name="ext"></param>
		/// <returns></returns>
		internal nilnul.Num _newestVer(
			nilnul.txt_._vered.Name prefix
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			IEnumerable<Num> s = parentAsInfo.EnumerateFiles().Select(
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
					x.name.ToString(), prefix
				)
			//x=>nilnul.txt_.vered.be_._NamedAsX.Be(prefix,x.ToString()) 
			)
			//.Select(
			//	x => nilnul.txt.Versioned1.Parse(x)
			//)
			.Select(x => new nilnul.Num(x.version));
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval(s) ;
			}
			return null;
		}
		/// <summary>
		/// gurantee the main's version is the smallest we get
		/// </summary>
		/// <param name="main"></param>
		/// <param name="ext"></param>
		/// <returns></returns>
		internal nilnul.NumI1 _newestVer_minVerGiven(
			nilnul.txt_.Vered2 main
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			IEnumerable<Num1> s = parentAsInfo.EnumerateFiles().Select(
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
					x.name.ToString(), main
				)
				&&
				
				x.version.toBigint()>=main.version.toBigint() 

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
					nilnul.nums_.started._MaxX._Eval(s.Select(x=> new nilnul.Num(x.toBigint())))
				);
			}
			return null;
		}

		internal nilnul.NumI1 newestVer(_address.doc_._exted.MainI doc, _address.doc_._exted.ExtI ext)
		{
			return _newestVer_minVerGiven(
				 nilnul.txt_.Vered2.Parse(doc.ToString())
				,
				ext
			);
			;
		}

		internal new nilnul.txt_.Vered2 newest(_address.doc_._exted.MainI doc, _address.doc_._exted.ExtI ext)
		{
			var vered =  nilnul.txt_.Vered2.Parse(doc.ToString());

			return new nilnul.txt_.Vered2(
				vered.name,
				_newestVer_minVerGiven(
				vered
				,
				ext
			)
				);
			;
		}

		internal nilnul.NumI1 newestVer(_address.doc_.MainExt doc)
		{
			return newestVer(
				doc.main
				,
				doc.ext
			);
			;
		}
		internal new nilnul.txt_.Vered2 newest(_address.doc_.MainExt doc)
		{
			return newest(
				doc.main
				,
				doc.ext
			);
			;
		}


		internal nilnul.NumI1 newestVer(DocI doc)
		{
			return newestVer(
				nilnul.fs._address.doc_.MainExt.Ov(doc)
			);
			;
		}

		internal new nilnul.txt_.Vered2 newest(DocI doc)
		{
			return newest(
				nilnul.fs._address.doc_.MainExt.Ov(doc)
			);
			;
		}

		public nilnul.Num _newestVer(
			nilnul.txt_._vered.Name prefix
			,
			nilnul.fs._address.doc_._exted.Ext ext
		)
		{
			return _newestVer(prefix, (nilnul.fs._address.doc_._exted.ExtI)(ext));
		}
		public nilnul.Num _newestVer(
			nilnul.txt_._vered.Name prefix
			,
			string ext
		)
		{
			return _newestVer(prefix, new nilnul.fs._address.doc_._exted.Ext(ext));
		}

		public nilnul.Num newestVer(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix
			, nilnul.fs._address.doc_.exted_._dotted.ExtI ext
		)
		{
			return _newestVer(prefix, ext);
		}



		public nilnul.NumI1 newestVer(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix
			, nilnul.Num min
			,
			nilnul.fs._address.doc_._exted.ExtI ext
			)
		{
			return _newestVer_minVerGiven(
				new nilnul.txt_.Vered2(prefix,min)
				,
				 ext);
		}
		public nilnul.NumI1 newestVer(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix, nilnul.Num min
			,
			nilnul.fs._address.doc_.exted_._dotted.ExtI ext
			)
		{
			return _newestVer_minVerGiven(
				new nilnul.txt_.Vered2(prefix,min)
				,
				 ext);
		}


		




	}
}
