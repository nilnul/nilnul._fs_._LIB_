using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnts
{
	/// <summary>
	/// eg:
	///		""
	///		a
	///		a\b
	///		
	/// </summary>
	public class Spliced : List<_address._route.division_._div._dir.DntI>
		,
		_address._route.DivisionI

	{



		public Spliced()
		{
		}

		

		public Spliced(IEnumerable<DntI> collection) : base(collection)
		{
		}

		public override string ToString()
		{
			return string.Join( System.IO.Path.DirectorySeparatorChar.ToString(), this);
		}
	}

	static public class SplicedX
	{
		static public nilnul.fs._address.DivisionI ToOldDivision(
			this _address._route.division_._div._dir.dnts.Spliced spliced
		) {
			return new nilnul.fs._address.dnts.Spliced(
				spliced.Select(d=> dnt._RegressionsX.ToOldDnt(d) )
			);
			
		}
	}
}
