using nilnul.fs._address.division.co._duct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.co_.spearPart
{
	/// <summary>
	/// </summary>
	static public class _MergeX
	{

		//static public nilnul.fs.address_.SpearI MakeSpear(nilnul.fs.address_.Shield origin, nilnul.fs.path_.contextual_.DivisionI route)
		//{
		//	return  new nilnul.fs.path_.Full(
		//		origin.vol
		//		,
		//		 path_.Rted.Ov(
		//			origin.stem
		//			,
		//			route
		//		)
		//	).makeSpear();

		//}

		static public nilnul.fs.AddressI Address(nilnul.fs.address_.SpearI origin, nilnul.fs.path_.IContextual route) {


			if (route is path_.Rted rt)
			{
				return new path_.Full(origin.vol, rt).toAddress();
			}
			else if (route is path_.contextual_.DivisionI division)
			{
				//var origionDivision = origin.sprig.document;

				var srcContainer = nilnul.fs.address_.spear._ContainerX.Shield(origin);
				/// use the container of the origion file
				///
				if (division is path_.division_.Div div)
				{
					if (div.Any())
					{
						var address =path.co_.shieldDivision._ConcatX.Address(srcContainer, div);
						return address;
					}
					else
					{
						return origin;
					}
				}
				else
				{
					return fs.path.co_.shieldDivision._ConcatX.Address(
						srcContainer, division
					);
				}

				//var routeAsRel = route as route_.Rel;
				//return new File(
				//	nilnul.fs.address_.folder.duo.route_.Rel.GenFolder( origin.folder, new folder.duo.route_.Rel( routeAsRel.parents, routeAsRel.sprig.stem)
				//	)
				//	,
				//	routeAsRel.sprig.doc
					
				//);
			}
			throw new UnexpectedTypeException();
		}

	}

	
}
