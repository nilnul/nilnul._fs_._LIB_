using System.Collections.Generic;

namespace nilnul.fs._address.div.co.commonAncestry_
{
	static public class _DivisionAsDivX
	{
		static public IEnumerable<DirI> Dirs(DivisionI x, DivisionI y)
		{
			return div.co._SharedPrefixX.Dirs(
				div_._DivisionX.Fro(x)
				,
				div_._DivisionX.Fro(y)
			);
		}
		static public Div Div(DivisionI x, DivisionI y)
		{
			return new Div(Dirs(x, y));
		}


	}
}
