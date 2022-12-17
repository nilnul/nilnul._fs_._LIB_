using System.Collections.Generic;

namespace nilnul.fs._address.dir
{
	static public class EqX

	{

		static public bool Eq(this IEqualityComparer<DirI> eq, DirI x, DirI y)
		{
			return eq.Equals(x, y);
		}

		static public bool Eq(this IEqualityComparer<DirI> eq, DirI x, string y)
		{
			return Eq(eq, x, Dir.Parse(y));
		}
		static public bool Eq(this IEqualityComparer<DirI> eq, string x1, DirI y)
		{
			return Eq(eq, y, (x1));
		}

		static public bool Eq(this IEqualityComparer<DirI> eq, string x, string y)
		{
			return Eq(eq, Dir.Parse(x), y);
		}


	}
}
