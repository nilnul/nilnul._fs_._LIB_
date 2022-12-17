using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dst_.cfg_.nn_
{
	/// <summary>
	/// such as:
	///		.nilnul
	///		.nilnul.xml
	///		.nilnul.ini
	///		.nilnul0.xml
	///		.nilnul00.ini
	///		.nilnul01.xmc     #xml content, in otherwords, frag
	///		.nilnul1
	/// </summary>
	static public class _ExtedsX
	{
		//public const string REGEX = $@"\.nilnul\d*()?";

		public const string _Regex_ver = "ver";
		public const string _Regex_ext = "ext";
		public const string _Regex_deck = "deck";


		public static Regex Regex = new Regex(
			@"\A\.nilnul(?'ver'\d*)(?'ext'\.[^\.]*)*(?'deck'[\\/])?\z"
			
		);
		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Ver9exts_addressAssumeFolder(
			string folder
		) {

			return nilnul.fs.folder._Dsts1._DstAsTxtEs_addressAssumeFolder(folder).Select(
				d=> Regex.Match(
					d
				)
			).Where(m=>m.Success).Select(
				m1 => (
					m1.Groups[_Regex_ver].Value
					,
					m1.Groups[_Regex_ext].Captures.Cast<Capture>().Select(c=>c.Value)
					,
					m1.Groups[_Regex_deck].Captures.Count>0
				)
			);
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> Ver9exts(nilnul.fs.FolderI1 folder) {

			return _Ver9exts_addressAssumeFolder(folder.ToString());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		/// alias:
		///		latest
		///		newest
		///		max

		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> Maximal(nilnul.fs.FolderI1 folder) {

			return  nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				Ver9exts(folder)
				,
				
				(v1,v2)=>nilnul.txt_.num_.radix_.dec._CompareX._Comp_assumesDigits(v1.ver,v2.ver)>0
			);
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Maximal_addressAssumeFolder(
			string folder
		) {

			return  nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				_Ver9exts_addressAssumeFolder(folder)
				,
				
				(v1,v2)=>nilnul.txt_.num_.radix_.dec._CompareX._Comp_assumesDigits(v1.ver,v2.ver)>0
			);
		}


		/// <summary>
		/// newest dirs might be empty if obsoleted by doc, if:
		///		abc1
		///		abc0/
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>

		static public IEnumerable<(string ver, IEnumerable<string> exts)> MaxDirs(nilnul.fs.FolderI1 folder) {

			return Maximal(folder).Where(x=>x.beDir).Select( y=>(y.ver,y.exts));
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts)> MaxDocs(nilnul.fs.FolderI1 folder) {

			return Maximal(folder).Where(x=>!x.beDir).Select( y=>(y.ver,y.exts));
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts)> MaxDocs(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> maxDsts) {

			return maxDsts.Where(x=>!x.beDir).Select( y=>(y.ver,y.exts));
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts)> MaxDirs(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> maxDsts) {

			return maxDsts.Where(x=>x.beDir).Select( y=>(y.ver,y.exts));
		}

		static public (string ver, IEnumerable<string> exts, bool beDir) Active0default(
			IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> x
		) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				x
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}
		static public (string ver, IEnumerable<string> exts, bool beDir) _Active0default_addressAssumeFolder(
			string x
		) {

			return Active0default(
				_Maximal_addressAssumeFolder(x)
			);
		}
		static public (string ver, IEnumerable<string> exts, bool beDir) Active0default(
			nilnul.fs.FolderI1 x
		) {

			return Active0default(
				Maximal(x)
			);
		}



		static public (string ver, IEnumerable<string> exts) Active0default(
			IEnumerable<(string ver, IEnumerable<string> exts)> x
		) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				x
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}


		/// <summary>
		/// we may have multiple max-vereds like:
		///		abc0
		///		,
		///		abc00
		///	we choose the one with longest '0's as the one we write to. Others as archived, not active;
		/// </summary>
		/// <param name="folder"></param>
		/// <returns></returns>
		static public (string ver, IEnumerable<string> exts) Active0defaultDir(nilnul.fs.FolderI1 folder) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				MaxDirs(folder)
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}

		static public (string ver, IEnumerable<string> exts) Active0defaultDir(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> x) {

			return Active0default(
				MaxDirs(x)
	
			);
		}

		static public (string ver, IEnumerable<string> exts) Active0defaultDoc(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> x) {

			return Active0default(
				MaxDocs(x)
	
			);
		}



		static public (string ver, IEnumerable<string> exts) Active0defaultDoc(nilnul.fs.FolderI1 folder) {

			return Active0defaultDoc(
				Maximal(folder)
			);

		}



	}
}
