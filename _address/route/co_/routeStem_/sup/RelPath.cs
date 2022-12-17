using nilnul.fs._address.divDivision;
using nilnul.fs._address.route_;

namespace nilnul.fs._address.route.co_.routeStem_.sup
{


	static public class _RelPathX
	{


		static public nilnul.fs._address._route.DivisionI Denotation(
			RouteI sup
			,
			SprigI sprig1
		)
		{
			return sup switch
			{
				route_.StemI stem => _address.route.co_.stemSprig_.sup._DifX.Denotation(stem, sprig1)
				,
				route_.SprigI sprigSup => _address.route_.sprig.co_.sup._RelPathX.RelPath(sprigSup,sprig1)

			};

		}

		


	}
}
