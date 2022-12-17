using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._route.division_.div.co_.sup
{
	static public class _DifX2
	{
		static public IEnumerable<_div.DirI> _Dirs_ofSupSub(DivI sup, DivI sub)
		{
			return sub.Skip(sup.Count());
		}
		static public Div _ofSupSub(DivI sup, DivI sub)
		{
			return new Div(_Dirs_ofSupSub(sup, sub));
		}

		static public IEnumerable<_address.DirI> _Dirs_ofSupSub(_address. DivI sup, _address. DivI sub)
		{
			return sub.dirs.Skip(sup.dirs.Count());
		}
		static public _address.Div _ofSupSub(_address. DivI sup,_address. DivI sub)
		{
			return new _address.Div(_Dirs_ofSupSub(sup, sub));
		}


	}
}
