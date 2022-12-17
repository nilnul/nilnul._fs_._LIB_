using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir_
{
	[Obsolete()]
	static public class _DstX1
	{
		static public DirI1 CreateFroDst(string dst)
		{
			return CreateFroDst(DstIX.Parse(dst));
		}

		static public DirI1 CreateFroDst(DstI1 dst)
		{
			return new Dir1(dst.name);

		}


	}
}
