using System.Collections.Generic;

namespace nilnul.fs._address.dst
{
	static public class _EqX 
	{
		static public bool Eq(this DstI x, string y)
		{
			return dst.Eq.Singleton.Equals(x, 
				DstA.Parse(y)
			);
		}

		static public bool Eq(this dst.Eq eq,  DstI x, string y)
		{
			return eq.Equals(x, 
				DstA.Parse(y)
			);
		}
		static public bool Eq(this dst.Eq eq,  string y, DstI x)
		{
			return Eq(eq,x,y);
		}

	}
}
