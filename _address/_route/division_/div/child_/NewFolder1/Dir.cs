using System;
using System.Linq;
using System.Linq.Expressions;
namespace nilnul.fs._address.div
{
	[Obsolete()]
	static public class _DirX
	{
		static public _address.Div Join(DivI div, _address.DirI doc)
		{
			return new Div(
				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					div.dirs, doc 
				)

			);

		}

		static public _address.Div Join(DivI div, DstI doc)
		{
			return Join(div, new _address.Dir(doc));

			//throw new NotImplementedException();
		}



	}
}
