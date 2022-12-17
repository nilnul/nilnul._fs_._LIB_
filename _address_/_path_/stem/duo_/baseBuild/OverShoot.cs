using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_.stem.duo_.baseBuild
{
	/// <summary>
	/// Item1 is the base of Item2. in other words:
	/// 1) Item1 = Item2,or
	/// 2) Item1 is the parent of Item2.
	/// 
	/// </summary>
	public class OverShoot
	{
		static public Stem _Eval(Stem _base, Stem _selfOrChild ) {

			return new Stem( _Eval(_base.dirs.ed, _selfOrChild.dirs.ed) );

		}

		static public IEnumerable<_path.Dst> _Eval(IEnumerable<_path.Dst> _base, IEnumerable<_path.Dst> _selfOrChild) {

			return _selfOrChild.Skip(_base.Count());


		}
	}
}
