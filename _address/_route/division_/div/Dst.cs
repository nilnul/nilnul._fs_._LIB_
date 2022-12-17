using System;

namespace nilnul.fs._address._route.division_.div
{
	static public class _ChildX
	{
		static public _address._route.DivisionI Join(DivI div, _address._route.division_._div.DstI dst)
		{
			switch (
				_address._route.division_._div.DstA.Of(dst)
			)
			{
				case _address._route.division_._div._dir.DntI doc:
					return new _address._route.division_.div.Dnted(div, doc);
				case _address._route.division_._div.DirI dir:
					return _address._route.division_.div.child_._DirX.Join(div, dir);
				default:
					throw new UnexpectedTypeException();
					break;
			}

		}




	}
}
