using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.spear.co
{
	static public class _RelPathX
	{
		[Obsolete("Not null. the name"+" " + nameof(Nulable) + " "+ "is misleading.")]
		static public nilnul.fs.AnchorI Nulable(SpearI from, SpearI to)
		{
			if (nilnul.fs.address_.spear.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.route_.sprig.co._RelPathX.RelPath(from.sprig, to.sprig);
				
			}
			return to;
		}

		static public nilnul.fs.IPath Path_froContainer(SpearI from, SpearI to)
		{
			return nilnul.fs.address.co_.shieldSpear._RelPathX.Path(
				 nilnul.fs.address_.spear._ContainerX.Shield(from)
				
				,
				to
			);


			//if (nilnul.fs.address_.spear.re_.equiv_._SameVolX.Re(from,to))
			//{
			//	return nilnul.fs._address.route_.sprig.co._RelPathX.Denotation_froContainer(from.sprig, to.sprig);
				
			//}
			//return to;
		}

		static public nilnul.fs.IPath Path_srcMadeShield(SpearI from, SpearI to)
		{
			return nilnul.fs.address.co_.shieldSpear._RelPathX.Path(
				 nilnul.fs.address_.Shield.Ov(from)
				
				,
				to
			);
			
		}




	}
}
