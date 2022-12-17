using nilnul.fs.address_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address.co
{
	/// <summary>
	/// from the perspective of destination, the travel history since an origin
	/// </summary>
	static public class _TrajectX
	{
		static public nilnul.fs.address.co._traject.IShortcut Shortcut(nilnul.fs.AddressI from, nilnul.fs.AddressI to)
		{
			
			if (nilnul.fs.address.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.division.co.RelPathX.RelPath(from.route.division, to.route.division);
				
			}
			return to;
		}
		static public nilnul.fs.IPath Path_sinceContainerIfSpear(nilnul.fs.AddressI from, nilnul.fs.AddressI to)
		{
			
			if (nilnul.fs.address.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.division.co.RelPathX.Path_sinceContainerIfDenotation(from.route.division, to.route.division);
			}
			return to;
		}

		static public nilnul.fs.IPath Path_srcMadeShieldIfSpear(nilnul.fs.AddressI from, nilnul.fs.AddressI to)
		{
			
			if (nilnul.fs.address.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.division.co.RelPathX.Path_srcMadeDivIfDenotation(from.route.division, to.route.division);
				
			}
			return to;
		}


	}
}
