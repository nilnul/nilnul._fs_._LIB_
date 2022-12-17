using System;
using System.Collections.Generic;

namespace nilnul.fs._address.division
{

	[Obsolete()]
	static public class _DenotesX
	{

		static public IEnumerable<nilnul.fs._address._dst.Denote> Seq(DivisionI division)
		{
			switch (division)
			{
				case DivI div:
					return _address.div._DenotesX.Seq(div);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
				case DocumentI document:
					return _address.document._DenotesX.Seq(document);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected

				default:
					return Seq(division.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		static public IEnumerable<nilnul.fs._address._dst.Denote> Seq(string s)
		{

			return Seq(DivisionA.Parse(s));

		}
	}
}
