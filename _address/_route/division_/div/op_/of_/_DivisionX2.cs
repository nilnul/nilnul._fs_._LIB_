using System;

namespace nilnul.fs._address._route.division_.div.op_.of_
{
	static public class _DivisionX
	{
		static public DivI _Of(DivisionI division)
		{
			switch (division)
			{
				case DivI div:
					return div;
				case div.DntedI document:
					return div.op_.binary_.Concat.Singleton.op(
						document.div, document.dnt
					);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public DivI OfDivision(string division)
		{
			return _Of(
				nilnul.fs._address._route.DivisionA.Parse(division)
			);
		}
		[Obsolete("defending against obsolete types")]
		static public DivI OfDivisionTxt(DivisionI division)
		{
			return OfDivision(division.ToString());
		}
	}
}
