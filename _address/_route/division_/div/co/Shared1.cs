using System.Collections.Generic;

namespace nilnul.fs._address.div.co
{
	static public class _SharedPrefixX
	{
		static public IEnumerable<DirI> Dirs(DivI x, DivI y)
		{
			return dirs.op_.binary_._SharedPrefixX.Op(x.dirs, y.dirs);
		}
		static public Div Div(DivI x, DivI y)
		{
			return new Div(Dirs(x, y));
		}


	}
}
