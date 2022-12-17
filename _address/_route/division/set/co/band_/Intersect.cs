using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.set.co.band_
{
	/// <summary>
	/// </summary>
	static public class _IntersectX
	{
		static public division.Set Band(
			division.Set a
			,
			division.Set b

		)
		{
			return new Set(
				a.Intersect(b, nilnul.fs._address.division.Eq.Singleton).ToArray()
			);
		}

		public static division.Set Band(IEnumerable<DivisionI> enumerable1, IEnumerable<DivisionI> enumerable2)
		{

			return Band(
				new Set(enumerable1), new Set(enumerable2)
			);
		}
	}
}
