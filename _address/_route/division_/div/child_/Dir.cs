using System.Linq;
using System.Linq.Expressions;
namespace nilnul.fs._address._route.division_.div.child_
{
	static public class _DirX
	{
		static public Div Join(DivI div, _address._route.division_._div.DirI doc)
		{
			return new Div(
				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					div, doc 
				)

			);

		}

		static public Div Join(DivI div, _address._route.division_._div.DstI doc)
		{
			return Join(div,  _address._route.division_._div.Dir.Of(doc));

			//throw new NotImplementedException();
		}



	}
}
