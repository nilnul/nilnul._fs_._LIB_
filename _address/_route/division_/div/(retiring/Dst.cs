using System;

namespace nilnul.fs._address.div
{
	[Obsolete()]
	static public class _DstX
	{
		static public _address.DivisionI Join(DivI div, _address.DstI dst)
		{
			switch (
				_address.DstA.Normal(dst)
			)
			{
				case _address.DocI doc:
					return _address.div._DocX.Join(div, doc);
				case _address.DirI dir:
					return _address.div._DirX.Join(div, dir);
				default:
					throw new UnexpectedTypeException();
					break;
			}

		}




	}
}
