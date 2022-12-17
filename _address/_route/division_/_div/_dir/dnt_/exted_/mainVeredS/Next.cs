using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.doc_.exted_.mainVeredS
{
	static public class _NextX
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		static public nilnul.Num NextVer(
			IEnumerable<string> docs
			,
			nilnul.txt_._vered.Name prefix
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			IEnumerable<Num> s = docs
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


		static public string Next(
			IEnumerable<string> docs
			,
			nilnul.txt_._vered.Name vered
			,
			nilnul.fs._address.doc_._exted.ExtI ext
		)
		{
			return $"{vered}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(NextVer(docs, vered, ext))}{ext}";
		}

		public static string Next(IEnumerable<string> enumerable, string main)
		{
			var mainExt = doc_.MainExt.Parse(main);
			return Next(
				enumerable
				,
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
					mainExt.main
				)

				, mainExt.ext
			);
		}
	}
}
