using nilnul.fs._address._route.division_.div;
using nilnul.fs._address.dir.str_;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs._address._route.division_
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
	public class Div
		: nilnul.obj.Box1<_div.DirI[]>
		, DivI

	{
	//	public SeqI dirs => new nilnul.fs._address.dir.str_.Seq(boxed);

		public Div(params _div.DirI[] dsts) : base(dsts)
		{

		}
		public Div(IEnumerable<_div.DirI> val) : this(
			val
			.ToArray()	//import for lazy exception
		)
		{
		}
		public Div() : this(new _div.DirI[0])
		{

		}


		public Div(_route.division_.div_. DirectoryI directory) : this( (IEnumerable<_div.DirI>)directory)
		{

		}


		public Div(IEnumerable<_div.Dir> enumerable)
			: this(enumerable.Cast<_div.DirI>() )
		{
		}



		public Div(IEnumerable<_div.DstI> enumerable)
			: this(enumerable.Select(x =>_div.Dir.Of(x)))
		{
		}

		public Div(IEnumerable<_div. _dir.IDnt> item1):this(
			item1.Select(dnt=> new _address._route.division_._div.Dir(dnt))
		)
		{
		}

		public Div(IEnumerable<_div. _dir.DntI> item1):this(
			item1.Select(dnt=> new _address._route.division_._div.Dir(dnt))
		)
		{
		}

		public Div(div.Dnted document):this(
			(IEnumerable<_div._dir.DntI>)(document)
		)
		{

		}
		public Div(IDnted denotation):this(
			  Dnted.Of(denotation)
		)
		{
		}

		public override string ToString()
		{
			return ToTxt(boxed);
		}

		public static string ToTxt(IEnumerable<nilnul.fs._address._route.division_._div.DirI> dirs)
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
				(splitResult).Take(splitResult.Length - 1).Select(y => _route.division_._div. Dir.Parse(y))
			);
		}



		static public Div OfDnts(IEnumerable<string> dsts)
		{
			return new Div(

				dsts.Select(x => new _route.division_._div._dir.Dnt(x))
			);
		}


		static public Div OfDsts(IEnumerable<string> dsts)
		{
			return new Div(

				dsts.Select(x => _route.division_._div.DstA.Parse(x))
			);
		}


		static public Div OfDsts(params string[] dsts)
		{
			return OfDsts((IEnumerable<string>)dsts  );
		}

		public IEnumerator<_div.DirI> GetEnumerator()
		{
			foreach (var item in boxed)
			{
				yield return item;
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
