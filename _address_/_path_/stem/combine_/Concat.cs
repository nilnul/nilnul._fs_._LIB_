using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_.stem.combine_
{
	public class Concat
	{
		static public Stem Eval(Stem a, Stem b) {
			return new Stem( a.dirs.ed.Concat(b.dirs.ed));
		}
	}
}
