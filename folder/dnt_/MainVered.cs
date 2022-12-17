using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.denote_
{
	//[Obsolete(nameof(denote_.mainVered_.minVer_.Next))]
	public class MainVered
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

		public MainVered(
			nilnul.fs.FolderI folder
		)
		{
			_parent = folder;
		}

		public MainVered(
			nilnul.fs.address_.ShieldI parent
		) : this(
			new nilnul.fs.Folder(parent)
		)
		{

		}

		public static MainVered OvAddress(string address)
		{
			return new MainVered(nilnul.fs.Folder.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo parentAsInfo => new DirectoryInfo(_parent.ToString());

		internal nilnul.Num _nextVer(
			nilnul.txt_._vered.Name prefix
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			IEnumerable<Num> s = parentAsInfo.EnumerateFileSystemInfos().Select(
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
				return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}
		/// <summary>
		/// gurantee the main's version is the smallest we get
		/// </summary>
		/// <param name="main"></param>
		/// <param name="ext"></param>
		/// <returns></returns>
		internal nilnul.NumI1 _nextVer_minVerGiven(
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
					x.name.ToString(), main
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
					nilnul.nums_.started._MaxX._Eval(s.Select(x=> new nilnul.Num(x.toBigint()))) + (nilnul.Num)1
				);
			}
			return main.version;
		}
		public nilnul.Num _nextVer(
			nilnul.txt_._vered.Name prefix
			,
			nilnul.fs._address.doc_._exted.Ext ext
		)
		{
			return _nextVer(prefix, (nilnul.fs._address.doc_._exted.ExtI)(ext));
		}
		public nilnul.Num _nextVer(
			nilnul.txt_._vered.Name prefix
			,
			string ext
		)
		{
			return _nextVer(prefix, new nilnul.fs._address.doc_._exted.Ext(ext));
		}

		public nilnul.Num nextVer(nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix, nilnul.fs._address.doc_.exted_._dotted.ExtI ext)
		{
			return _nextVer(prefix, ext);
		}

		/// <summary>
		/// nextVer for a monolithic(no dot;no ext) fileName
		/// </summary>
		/// <param name="prefix"></param>
		/// <param name="min"></param>
		/// <returns></returns>
		public nilnul.Num nextVer(nilnul.fs._address.doc_.exted_._noDot.main_._vered.Name prefix, nilnul.Num min

			)
		{
			return nilnul.num.op_.binary_.Max.Singleton.op(nextVer(prefix), min);
		}

		public nilnul.Num nextVer(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix, nilnul.Num min
			,
			nilnul.fs._address.doc_.exted_._dotted.ExtI ext
			)
		{
			return nilnul.num.op_.binary_.Max.Singleton.op(nextVer(prefix, ext), min);
		}

		public nilnul.Num nextVer(nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix, nilnul.fs._address.doc_.exted_._dotted.Ext_herit ext)
		{

			return nextVer(prefix,

				(nilnul.fs._address.doc_.exted_._dotted.ExtI)
				nilnul.fs._address.doc_.exted_._dotted.Ext_herit.Ov(ext)
			);
		}

		public nilnul.Num nextVer(nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name prefix, nilnul.fs._address.doc_._exted.ext_.OvAftDotI ext)
		{

			return nextVer(prefix,

				//(nilnul.fs._address.doc_.exted_._dotted.ExtI)
				nilnul.fs._address.doc_.exted_._dotted.Ext_herit.Ov(ext)
			);
		}

		public nilnul.Num nextVer(nilnul.fs._address.doc_.exted_._noDot.main_._vered.Name prefix)
		{
			return _nextVer(prefix, "");
		}



		public nilnul.Num nextVer_ofGerm(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			var ext111 = nilnul.fs._address.doc_._exted.Ext_emptyOrLedA.Parse(
				ext
			);
			switch (ext111)
			{
				case _address.doc_._exted.ext_.Empty empty:
					return nextVer(
						 _address.doc_.exted_._noDot.main_._vered.Name.CreateByAppendingSubIfNeed(
							prefix
						)
					);
				case _address.doc_._exted.ext_.OvAftDot ovAftDot:
					return nextVer(
						 _address.doc_.exted_._dotted.main_._vered.Name.CreateByAppendingSubIfNeed(
							prefix
						)
						,
						 _address.doc_.exted_._dotted.Ext_herit.OvLed(ext.ToString())
				);
				default:
					throw new UnexpectedTypeException();
			}
		}


		public nilnul.Num nextVer(nilnul.txt_._vered_.Name prefix, nilnul.fs._address.doc_._exted.Ext ext)
		{
			return nextVer_ofGerm(prefix, (nilnul.fs._address.doc_._exted.ExtI)ext);
		}

		//public nilnul.Num nextVer_apendSubIfNeed(string main, nilnul.fs._address.doc_._exted.ExtI ext)
		//{
		//	return nextVer_ofGerm(
		//		nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(main)
		//		, 
		//		//(nilnul.fs._address.doc_._exted.ExtI)
		//		ext
		//	);
		//}

		//public nilnul.Num nextVer_apendSubIfNeed(nilnul.fs._address.doc_.MainExt doc)
		//{
		//	return nextVer_apendSubIfNeed(doc.main,doc.ext);
		//}

		//public nilnul.Num nextVer_apendSubIfNeed(nilnul.fs._address.DocI	doc)
		//{
		//	return nextVer_apendSubIfNeed( _address.doc_.MainExt.Ov(doc));
		//}



		public nilnul.Num nextVer(nilnul.txt_._vered_.Name prefix, string ext)
		{
			return nextVer(prefix, new nilnul.fs._address.doc_._exted.Ext(ext));
		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix">parse the name out of the vered; ver is discarded</param>
		/// <param name="ext"></param>
		/// <returns></returns>
		public nilnul.Num nextVer(string prefix, string ext)
		{

			return nextVer(nilnul.txt_.Vered.Parse(prefix).name, ext);

		}
		public string next(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name main
			,
			nilnul.fs._address.doc_.exted_._dotted.ExtI ext
		)
		{
			return $"{main}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(main, ext))}{ext}";
			//return next(main.en, ext);
		}

		public string next(
			nilnul.fs._address.doc_.exted_._noDot.main_._vered.Name main

		)
		{
			return $"{main}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(main))}";
		}

		public string next(nilnul.txt_._vered_.Name vered, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return $"{vered}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer_ofGerm(vered, ext))}{ext}";
		}


		public string next(
			nilnul.fs._address._dst.denote_._vered_.Germ germ, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return $"{germ}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer_ofGerm(germ, ext))}{ext}";
		}

		public string next(
			nilnul.fs._address.doc_.exted_._dotted.main_._vered.Name germ, nilnul.Num min, nilnul.fs._address.doc_.exted_._dotted.ExtI ext)
		{
			return $"{germ}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(germ, min, ext))}{ext}";
		}







		[Obsolete()]
		public string next(nilnul.txt_.Vered vered, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return next(vered.name, ext);
		}
		[Obsolete()]
		public string next(nilnul.txt_.Vered vered, nilnul.fs._address.doc_._exted.Ext ext)
		{
			return next(vered, (nilnul.fs._address.doc_._exted.ExtI)ext);
		}

		public string next_ofGerm(string germ, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return $"{germ}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer_ofGerm(germ, ext))}{ext}";
		}

		public string next_ofGerm(string germ, _address.doc_._exted.Ext ext)
		{
			return next_ofGerm(germ, (_address.doc_._exted.ExtI)(ext));
		}

		public string next_ofGerm(string germ, string ext)
		{
			return next_ofGerm(germ, new nilnul.fs._address.doc_._exted.Ext(ext));
		}


		//public string next_germAppendSubIfNeed(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		//{
		//	return next_ofGerm(nilnul.txt_._vered.Name._CreateByAppendingUnderscoreIfNecessary(prefix), ext);
		//}


		[Obsolete()]
		public string next(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return new mainVered_.appendSubIfNeed_.Next(this.parent).denote(prefix, ext);
			//			//(nilnul.txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(prefix), ext);
			//#pragma warning disable CS0162 // Unreachable code detected
			//			return next(nilnul.txt_.Vered.Parse(prefix), ext);
			//#pragma warning restore CS0162 // Unreachable code detected

			//			//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		}
		[Obsolete(nameof(denote_.mainVered_.minVer_.Next))]
		public string next(
			nilnul.fs._address.doc_._exted.Main main
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			var ext111 = nilnul.fs._address.doc_._exted.Ext_emptyOrLedA.Parse(
				ext
			);
			switch (ext111)
			{
				case _address.doc_._exted.ext_.Empty empty:
					return next(
						 _address.doc_.exted_._noDot.main_._vered.Name.CreateByAppendingSubIfNeed(
							main
						)
					);
				case _address.doc_._exted.ext_.OvAftDot ovAftDot:
					return next(
						 _address.doc_.exted_._dotted.main_._vered.Name.CreateByAppendingSubIfNeed(
							main
						)
						,
						 _address.doc_.exted_._dotted.Ext_herit.OvLed(ext.ToString())
				);
				default:
					throw new UnexpectedTypeException();
			}
		}


		public string next(nilnul.fs._address.doc_.MainExt doc)
		{
			return next(doc.main, doc.ext);
		}

	

		public string next(
		nilnul.fs._address.DocI doc)
		{
			return next(
				 nilnul.fs._address.doc_.MainExt.Ov(doc)

			);
		}

		public string next_ofDoc(string doc)
		{
			return next(_address.doc_.MainExt.Parse(doc));
		}

		public string next(string doc)
		{
			return next_ofDoc(doc);
		}

		public string next(nilnul.txt_.Vered vered, string ext)
		{
			return next(vered, new nilnul.fs._address.doc_._exted.Ext(ext));
			//return $"{vered.name}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(vered.name,ext))}.{ext}";
		}

		//public string next_germAppendSubIfNeed(string prefix, nilnul.fs._address.doc_._exted.Ext ext)
		//{
		//	return next_germAppendSubIfNeed(
		//		(prefix),

		//		(_address.doc_._exted.ExtI)(
		//			ext
		//		)

		//	);
		//	//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		//}

		//public string next_germAppendSubIfNeed(string prefix, string ext)
		//{
		//	return next_germAppendSubIfNeed(
		//		(prefix),
		//		new nilnul.fs._address.doc_._exted.Ext
		//		(
		//			ext
		//		)

		//	);
		//}
		public string next(string prefix, string ext)
		{
			return next(
				new nilnul.fs._address.doc_.MainExt(prefix, ext)
			);
			
			//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		}

		public string nextAddress(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return $"{_parent}{next(prefix, ext)}";
		}



		public string nextAddress(string prefix, string ext)
		{
			return $"{_parent}{next(prefix, ext)}";
		}

		public string nextAddress(string doc)
		{
			return $"{_parent}{next(doc)}";
		}




	}
}
