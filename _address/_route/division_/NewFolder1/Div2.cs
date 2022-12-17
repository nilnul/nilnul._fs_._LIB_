using nilnul.fs._address.dir.str_;
using System;
using System.Collections.Generic;
using System.Linq;
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
		: nilnul.obj.Box<DirI[]>
		, DivI

	{
		public SeqI dirs => new nilnul.fs._address.dir.str_.Seq(boxed);

		public Div(params DirI[] dsts) : base(dsts)
		{

		}
		public Div(DirectoryI directory) : this(directory.Dirs())
		{

		}

		public Div(nilnul.fs._address.dir.str_.SeqI val) : this(val.ToArray())
		{
		}



		public Div() : this(new DirI[0])
		{

		}



		//public EnumableI1 dirs => boxed;

		public Div(IEnumerable<DirI> enumerable)
			: this(new nilnul.fs._address.dir.str_.Seq(enumerable))
		{
		}



		public Div(IEnumerable<DstI> enumerable)
			: this(enumerable.Select(x => dir_._DstX.CreateFroDst(x)))
		{
		}

		public Div(IEnumerable<IDnt> item1):this(
			item1.Select(dnt=> new _address.Dir(dnt))
		)
		{
		}

		public Div(DocumentI document):this(
			fs._address.document._DenotesX.Seq(document)
		)
		{

		}
		public Div(IDenotation denotation):this(
			DenotationX.Document(denotation)
		)
		{
		}

		public override string ToString()
		{
			return ToTxt(boxed);
		}

		public static string ToTxt(IEnumerable<nilnul.fs._address.DirI> dirs)
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
			try
			{
			nilnul.txt.be_.empty.Vow.Singleton.vow(
				splitResult.Last()
			);

			}
			catch (nilnul.obj_.xpn_.UnacceptableException ex)
			{

				throw new nilnul.obj_.xpn_.ParseException($"the last segment of {x} must be empty");
			}

			return new Div(
				(splitResult).Take(splitResult.Length - 1).Select(y => Dir.Parse(y)).ToArray()
			);
		}





		static public Div CreateFroDsts(IEnumerable<string> dsts)
		{
			return new Div(

				dsts.Select(x => dir_._DstX.CreateFroDst(x))
			);
		}
		static public Div OvDnts(IEnumerable<string> dsts)
		{
			return new Div(

				dsts.Select(x => Dir.OvDenote(x))
			);
		}


		static public Div CreateFroDsts(params string[] dsts)
		{
			return CreateFroDsts(dsts as IEnumerable<string>);
		}













	}
}
