using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.set.co.convert_
{
	/// <summary>
	/// return a set.Co, that is A-B and B-A, where "-" means except
	/// </summary>
	static public class _DeltaX
	{
		static public (division.Set, division.Set) Delta(
			division.Set a
			,
			division.Set b

		) {
			var intersected = band_._IntersectX.Band(a, b);

			return ( band_._ExceptX.Band(a, intersected) , band_._ExceptX.Band(b,intersected));

		}

		public static (division.Set, division.Set) Delta(IEnumerable<DivisionI> enumerable1, IEnumerable<DivisionI> enumerable2)
		{
			return Delta(new Set(enumerable1), new Set(enumerable2));
		}
	}
}
