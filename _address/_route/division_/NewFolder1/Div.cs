using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;
using System.Text.RegularExpressions;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// such as :
	///		""
	///		"a\"
	///		,"a\b\"
	/// </summary>
	/// 
	[Obsolete()]
	public class Div

		: nilnul.obj.Box<DirsI>
		,DivI

	{

		public Div(DirsI val) : base(val)
		{
		}

		public Div() : this(new Dirs())
		{

		}

		public DirsI dirs { get {
				return boxed;
			} }

		public Div(IEnumerable<Dir> enumerable)
			: this(new Dirs(enumerable))
		{
		}

		

		public Div(IEnumerable<DstI> enumerable)
			: this(new Dirs(enumerable))
		{
		}

		public Div(IEnumerable<DirI> enumerable)
			:this(new Dirs(enumerable))
		{
		}

		public override string ToString()
		{
			return ToTxt(boxed);
		}

		public static string ToTxt(DirsI dirs)
		{
			return nilnul.txts.accumulate_.join_.Empty.Singleton.accumulate(
				dirs.Select(x =>
					(x).ToString()
				)
			);
			//throw new NotImplementedException();
		}


		static public Div Parse(string x)
		{

			var splitResult = Regex.Split(x, @"(?<=\\)|(?<=\/)").ToArray();
			nilnul.txt.be_.empty.Vow.Singleton.vow(
				splitResult.Last()
				,
				$@"{x} as div of dirs shall be empty after \ or /."
			);

			return new Div(
				(splitResult).Take( splitResult.Length-1).Select(y => Dir.Parse(y))
			);
		}

		



		static public Div CreateFroDsts(IEnumerable< string> dsts) {
			return new Div(

				Dsts.CreateFroDsts(dsts)
			);
		}

		static public Div CreateFroDsts(params  string[] dsts) {
			return new Div(

				Dsts.CreateFroDsts(dsts)
			);
		}



		static public Div CreateFroDirs(params Dir[] dsts) {
			return new Div(

				dsts
			);
		}


		static public Div CreateFroDirs(IEnumerable<DirI> dirs) {
			return new Div(

				dirs
			);
		}







	}
}
