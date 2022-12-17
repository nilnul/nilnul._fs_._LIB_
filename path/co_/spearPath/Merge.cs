using nilnul.fs._address.division.co._duct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.co_.spearPath
{
	/// <summary>
	/// get the relpath of two files.
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

		static public nilnul.fs.AddressI Address(nilnul.fs.address_.SpearI origin, nilnul.fs.IPath route) {


			if (route is nilnul.fs.path_.Full x)
			{
				return x.toAddress();//.makeSpear();
			}

			return spearPart._MergeX.Address(origin, (fs.path_.IContextual) route);
		
		}

		static public nilnul.fs.AddressI Address(string origin, nilnul.fs.IPath route) {


			return Address(
				nilnul.fs.address_.Spear.Parse(origin),route
			);
		
		}

		//static public RouteI GetRoute(
		//		nilnul.fs.address_.File origin
		//		,
		//		nilnul.fs.address_.File target
		//	)
		//{
		//	var commonBase = nilnul.fs.address_.folder.combine_.CommonBase.Eval_retNullable(
		//		origin.folder, target.folder

		//	);
		//	if (commonBase == null)
		//	{
		//		return new route_.Abs( target);
		//	}

		//	var stemsOfOriginOverCommon = nilnul.fs.address_.folder.duo_.baseBuild.OverShoot._Eval(commonBase, origin.folder);

		//	//var stemsOfTargetOverCommon = nilnul.fs.address_.folder.duo_.baseBuild.OverShoot._Eval(commonBase, target.folder);

		//	var sprigOfTargetOverCommon = nilnul.fs.address.duo_.folderDocument.OverShoot._Eval(commonBase, target);

		//	return new route_.Rel( 
		//		nilnul.fs.address.duo.route_._rel.Parents.CreateFroCount( stemsOfOriginOverCommon.dirs.Count())
		//		,
		//		sprigOfTargetOverCommon
				
		//	);


		//}
	}

	
}
