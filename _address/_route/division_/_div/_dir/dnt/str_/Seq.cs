using System.Collections.Generic;

namespace nilnul.fs._address._dst.denote.str_
{
	public interface SeqI
		:
		nilnul.fs._address._dst.denote.StrI
		,
		nilnul.fs._address._dst.denote.SeqI

	{
	}

	public class Seq :
		nilnul.obj.str_.Seq<Denote>
		,
		SeqI
	{
		public Seq(IEnumerable<Denote> boxed) : base(boxed)
		{
		}

		public Seq(DivisionI x):this( ToDenotes(x) )
		{

		}

		static public IEnumerable<Denote> ToDenotes(DivisionI x) {
			return fs._address.division._DenotesX.Seq(x);
		}
	}
}
