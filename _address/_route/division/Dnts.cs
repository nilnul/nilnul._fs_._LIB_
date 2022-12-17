using System.Collections.Generic;

namespace nilnul.fs._address._route.division
{
	static public class _DntsX
	{

		static public IEnumerable<nilnul.fs._address._route.division_._div._dir.DntI> Seq(DivisionI division)
		{
			switch (division)
			{
				case division_.DivI div:
					return _address._route.division_.div._DntsX.Seq(div);
					break;
				case division_.div.DntedI document:
					return _address._route.division_.div.dnted._DntsX.Seq(document);
					break;

				default:
					return Seq(division.ToString());
					break;
			}

		}

		static public IEnumerable<nilnul.fs._address._route.division_._div._dir.DntI> Seq(string s)
		{

			return Seq(DivisionA.Parse(s));

		}
	}
}
