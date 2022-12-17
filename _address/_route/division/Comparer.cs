using System.Collections.Generic;

namespace nilnul.fs._address.division
{
	public class Comparer : IComparer<nilnul.fs._address.DivisionI>
	{
		public int Compare(DivisionI x, DivisionI y)
		{
			var denotesCompared = nilnul.fs._address._dst.denote.str.Comparer.Singleton.Compare(
				nilnul.fs._address.division._DenotesX.Seq(x)
				,
				nilnul.fs._address.division._DenotesX.Seq(y)
			);
			if (denotesCompared == 0)
			{
				if (nilnul.fs._address.division.be_.Div.Singleton.be(x))
				{
					if (nilnul.fs._address.division.be_.Div.Singleton.be(y))
					{
						return 0;
					}
					return 1;
				}
				if (nilnul.fs._address.division.be_.Div.Singleton.be(y))
				{
					return -1;
				}
				return 0; //both document

			}
			return denotesCompared;
		}

		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}
