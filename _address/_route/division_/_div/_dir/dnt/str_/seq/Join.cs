using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._dst.denote.str_.seq
{
	/// <summary>
	/// join denote with "/"
	/// </summary>
	public class Join :
		nilnul.obj.Box<IEnumerable<Denote>>
		,
		nilnul.fs._address._dst.denote.str_.SeqI
	{
		public Join(IEnumerable<Denote> val) : base(val)
		{
		}

		public Join(DivisionI division):this(
			new str_.Seq(division)
		)
		{

		}

		public Join() : this(new Denote[0])
		{

		}

		public Join(IEnumerable<string> enumerable) : this(
			enumerable.Select(
				x => new Denote(x)
			)
		)
		{
		}

		static public IEnumerable<Denote> Parse2Str(string willNotTrim)
		{
			if (willNotTrim == "")
			{
				return new Denote[0];
			}
			var split = willNotTrim.Split(nilnul.characters_.DirSeperator.Chars);
			return split.Select(
				x => new nilnul.fs._address._dst.Denote(x)
			);
		}

		static public Join Parse(string willNotTrim)
		{
			return new Join(Parse2Str(willNotTrim));
		}


		public override string ToString()
		{
#pragma warning disable CS0612 // 'Path' is obsolete
			return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(this.boxed);
#pragma warning restore CS0612 // 'Path' is obsolete
			;
		}

		public Denote[] toArr()
		{
			return this.boxed.ToArray();
			//throw new NotImplementedException();
		}

		public nilnul.fs._address._dst.denote.str.join.Capped toDenotesCapped()
		{
			return new str.join.Capped(this.boxed);
		}
		public nilnul.fs._address.Div toDirectory()
		{
			return new Div(
				toDirs()
			);
		}

		public IEnumerable<nilnul.fs._address.Dir> toDirs()
		{
			return
				this.boxed.Select(x => new nilnul.fs._address.Dir(x))
			;
		}


		public nilnul.fs._address.route_.Stem toStem()
		{
			return new route_.Stem(
				toDiv()
			);
		}

		public nilnul.fs._address.DivI toDiv()
		{
			return new nilnul.fs._address.Div(toDirs());
		}

		public IEnumerator<Denote> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
