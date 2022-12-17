using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder._cfg_.div.dst_
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
	///		abc
	///		abc0
	///		abc001
	///		abc1
	///		abc.ini
	///		abc0.ini.aaa
	/// </summary>
	static public class _ExtedsX
	{

		public const string _Regex_ver = "ver";
		public const string _Regex_ext = "ext";
		public const string _Regex_deck = "deck";

		/// <summary>
		/// maximal or not
		/// </summary>
		/// <param name="_cfg_directory"></param>
		/// <param name="_stub">
		/// eg:
		///		abc
		///		abc.b
		///		abc3.
		///			as in abc3.3.de
		///		.abc
		///		.abc.ddd
		///	exclude:
		///		abc0
		///		
		/// </param>
		/// <returns></returns>

		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Ver9extes_addressAssumeFolder_assumeNub(
			string _cfg_directory
			,
			string _stub
		) {

			var regex = new Regex(
				$@"\A{Regex.Escape(_stub)}(?'ver'\d*)(?'ext'\.[^\.]*)*(?'deck'[\\/])?\z"
			);

			return nilnul.fs.folder._Dsts1._DstAsTxtEs_addressAssumeFolder(_cfg_directory).Select(
				d=> regex.Match(
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
		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Ver9extes_1assumeNub(
			nilnul.fs.FolderI1 _cfg_directory
			,
			string _stub
		) {

			return _Ver9extes_addressAssumeFolder_assumeNub(_cfg_directory.ToString(),_stub);
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Ver9extes_1assumeNub(
			nilnul.fs.FolderI _cfg_directory
			,
			string _stub
		) {

			return _Ver9extes_addressAssumeFolder_assumeNub(_cfg_directory.ToString(),_stub);
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

		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Maximal_addressAssumeFolder_assumeNub(
			string folder
			,
			string _stub
		) {

			return  nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				_Ver9extes_addressAssumeFolder_assumeNub(folder,_stub)
				,
				
				(v1,v2)=>nilnul.txt_.num_.radix_.dec._CompareX._Comp_assumesDigits(v1.ver,v2.ver)>0
			);
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Maximal_assumeNub(
			nilnul.fs.FolderI1 folder
			,
			string _stub
		) {

			return  nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				_Ver9extes_1assumeNub(folder,_stub)
				,
				
				(v1,v2)=>nilnul.txt_.num_.radix_.dec._CompareX._Comp_assumesDigits(v1.ver,v2.ver)>0
			);
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> _Maximal_assumeNub(
			nilnul.fs.FolderI folder
			,
			string _stub
		) {

			return  nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				_Ver9extes_1assumeNub(folder,_stub)
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

		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDirEs_assumeNub(nilnul.fs.FolderI1 folder
						,
			string _stub
		) {

			return _Maximal_assumeNub(folder, _stub).Where(x=>x.beDir).Select( y=>(y.ver,y.exts));
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDirEs_assumeNub(nilnul.fs.FolderI folder
						,
			string _stub
		) {

			return _Maximal_assumeNub(folder, _stub).Where(x=>x.beDir).Select( y=>(y.ver,y.exts));
		}


		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDirEs_addressAssumeFolder_assumeNub(string folder
						,
			string _stub
		) {

			return _Maximal_addressAssumeFolder_assumeNub(folder, _stub).Where(x=>x.beDir).Select( y=>(y.ver,y.exts));
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDocEs_assumeNub(nilnul.fs.FolderI1 folder, string _stub) {

			return _Maximal_assumeNub(folder, _stub).Where(x=>!x.beDir).Select( y=>(y.ver,y.exts));
		}

		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDocEs_assumeNub(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> maxDsts) {

			return maxDsts.Where(x=>!x.beDir).Select( y=>(y.ver,y.exts));
		}
		static public IEnumerable<(string ver, IEnumerable<string> exts)> _MaxDirEs_assumeNub(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> maxDsts) {

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

		static public (string ver, IEnumerable<string> exts, bool beDir) __Active0default_addressAssumeFolder_assumeNub(
			string x
						,
			string _stub
		) {

			return Active0default(
				_Maximal_addressAssumeFolder_assumeNub(x,_stub)
			);
		}

		static public (string ver, IEnumerable<string> exts, bool beDir) _Active0default_assumeNub(
			nilnul.fs.FolderI1 x
						,
			string _stub
		) {

			return Active0default(
				_Maximal_assumeNub(x,_stub)
			);
		}
		static public (string ver, IEnumerable<string> exts, bool beDir) _Active0default_assumeNub(
			nilnul.fs.FolderI x
						,
			string _stub
		) {

			return Active0default(
				_Maximal_assumeNub(x,_stub)
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
		static public (string ver, IEnumerable<string> exts) _Active0defaultDir_assumeNub(nilnul.fs.FolderI1 folder, string _stub) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				_MaxDirEs_assumeNub(folder, _stub)
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}

		static public (string ver, IEnumerable<string> exts) _Active0defaultDir_assumeNub(nilnul.fs.FolderI folder, string _stub) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				_MaxDirEs_assumeNub(folder, _stub)
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}

		static public (string ver, IEnumerable<string> exts) _Active0defaultDir_addressAssumeFolder_assumeNub(
			string folder
			,
			string _stub
		) {

			return nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				_MaxDirEs_addressAssumeFolder_assumeNub(folder, _stub)
				,
				t=>t.ver.TakeWhile(c=>c=='0').Count()
				,

				Comparer<int>.Default
			);
		}


		static public (string ver, IEnumerable<string> exts) Active0defaultDir(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> x) {

			return Active0default(
				_MaxDirEs_assumeNub(x)
	
			);
		}

		static public (string ver, IEnumerable<string> exts) Active0defaultDoc(IEnumerable<(string ver, IEnumerable<string> exts, bool beDir)> x) {

			return Active0default(
				_MaxDocEs_assumeNub(x)
	
			);
		}



		static public (string ver, IEnumerable<string> exts) _Active0defaultDoc_assumeNub(nilnul.fs.FolderI1 folder, string _stub) {

			return Active0defaultDoc(
				_Maximal_assumeNub(folder,_stub)
			);

		}



	}
}
