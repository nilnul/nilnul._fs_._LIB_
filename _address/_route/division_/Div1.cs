using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;
using System.Text.RegularExpressions;
using nilnul.fs._address.dir.str_;

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
	public class Div1
		: nilnul.obj.Box<nilnul.fs._address.dir.str_.EnumableI>
		,DivI1

	{

		public Div1(nilnul.fs._address.dir.str_.EnumableI val) : base(val)
		{
		}

		public Div1() : this(new nilnul.fs._address.dir.str_.Enumable())
		{

		}

		

		public EnumableI dirs => boxed;

		public Div1(IEnumerable<DirI1> enumerable)
			: this(new nilnul.fs._address.dir.str_.Enumable(enumerable))
		{
		}

		

		public Div1(IEnumerable<DstI1> enumerable)
			: this(enumerable.Select(x=> dir_._DstX1.CreateFroDst(x)))
		{
		}

		

		public override string ToString()
		{
			return ToTxt(boxed);
		}

		public static string ToTxt(IEnumerable<nilnul.fs._address.DirI1> dirs)
		{
			return nilnul.txts.accumulate_.join_.Empty.Singleton.accumulate(
				dirs.Select(x =>
					(x).ToString()
				)
			);
			//throw new NotImplementedException();
		}


		static public Div1 Parse(string x)
		{
			var splitResult = Regex.Split(x, @"(?<=\\)|(?<=\/)").ToArray();
			nilnul.txt.be_.empty.Vow.Singleton.vow(
				splitResult.Last()
			);

			return new Div1(
				(splitResult).Take( splitResult.Length-1).Select(y => Dir1.Parse(y))
			);
		}

		



		static public Div1 CreateFroDsts(IEnumerable< string> dsts) {
			return new Div1(

				dsts.Select(x=> dir_._DstX1.CreateFroDst(x))
			);
		}

		static public Div1 CreateFroDsts(params  string[] dsts) {
			return CreateFroDsts(dsts as IEnumerable<string>);
		}



		 public  Div1(params DirI1[] dsts):this(dsts as IEnumerable<DirI1>)
		{
			
		}


		







	}
}
