using System.Collections.Generic;

namespace nilnul.fs._address.doc
{
	static public class EqX
	{
		static public bool Eq(this IEqualityComparer<DocI> eq, DocI doc, string x)
		{
			return eq.Equals(doc, new Doc(x));
		}
		static public bool Eq(this IEqualityComparer<DocI> eq, Doc doc, string x)
		{
			return Eq(eq, (DocI)doc, (x));
		}
		static public bool Eq(this IEqualityComparer<DocI> eq, string doc, DocI x)
		{
			return Eq(eq, x, (doc));
		}

		static public bool Eq(this IEqualityComparer<DocI> eq, string doc, string x)
		{
			return Eq(eq, new Doc(doc), (x));
		}


	}
}
