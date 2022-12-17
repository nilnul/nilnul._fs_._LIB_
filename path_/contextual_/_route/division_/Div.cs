using nilnul.fs._address.dir.str_;
using nilnul.fs._address.div.co._relPath._ret_;
using nilnul.fs.path_.division_._div._dir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using D = nilnul.fs.path_.division_._div.Dir;

namespace nilnul.fs.path_.division_
{
	public class Div :
		nilnul.obj.str_.Enumable<path_.division_._div.Dir>
		,
		nilnul.fs.path_.contextual_.DivisionI
		

	{
		public Div(IEnumerable<D> boxed) : base(boxed)
		{
		}

		public Div(IEnumerable<IStep> boxed) : this(
			boxed.Select(
				s => new D(s)
			)
		)
		{
		}

		public Div() : this(new D[0])
		{
		}
		public Div(IEnumerable<IStep> boxed, IEnumerable<_address.IDnt> forwards)
			:
			this(boxed.Concat(forwards))
		{
		}
		public Div(IEnumerable<nilnul.fs.path_.division_._div._dir.step_.Up> boxed

			, IEnumerable<
_address.IDnt
			> forwards)
			:
			this((IEnumerable<IStep>)boxed  ,  forwards)
		{
		}

		public Div(IEnumerable<_div._dir. step_.Up> boxed, IEnumerable<_address.DirI> forwards) : this(
			boxed
			,
			(forwards).Select(x => x.denote)
		)
		{
		}

		public Div(int backs, IEnumerable<_address.DirI> forwards) : this(
			nilnul.obj.str_._ArrX.Generate(backs, 
				_div._dir.step_.Up.Singleton
			)
			,
			forwards
		)
		{
		}

		public Div(_address.DivI div):this(div.dirs)
		{
		}

		public Div(SeqI dirs):this(dirs.Select(dir=>dir.denote))
		{
		}

		static public Div Parse(string x) {
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
				(splitResult).Take(splitResult.Length - 1).Select(y => _div.Dir.Parse(y)).ToArray()
			);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns>"", a/, a/b/,  ../a/b/</returns>
		public override string ToString()
		{
			return string.Join(String.Empty, this);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="nameof(InvalidCastException)">
		///		step_.nonLiteral casted to literal
		/// </exception>
		public _address.Div _toLiteral()
		{
			return new _address.Div(
				_div._dir.steps.Shrink.Singleton._op( this.Select(dir=>dir.step))
				.Select(s=> new _address.Dnt(s.ToString()))
				//.Cast<_address.DntI1>()
			);
			//throw new NotImplementedException();
		}
		public _address.DivisionI toLiteral()
		{
			return _toLiteral();
			//throw new NotImplementedException();
		}
		public Div toShrink()
		{
			return new Div(
				_div._dir.steps.Shrink.Singleton._op( this.Select(dir=>dir.step))
				.Select(s => new _address.Dnt(s.ToString()))
				//.Cast<_address.DntI1>()
			);
			//throw new NotImplementedException();
		}

	}
}
