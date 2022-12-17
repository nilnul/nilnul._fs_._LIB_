using System;

namespace nilnul.fs._address.division
{
	static public class _LocalNameX
	{
		public static string _Name(DivisionI divisionI)
		{
			switch (divisionI)
			{
				case Document document1:
					return document._LocalNameX.Name(document1);
				case DivI div1:
					return div._LocalNameX.Name(div1);
				default:
					throw new UnexpectedTypeException("division has to be either document or div. obsolete types shall not be used");
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
			//throw new NotImplementedException();
		}

		static public string Name(string division)
		{
			return _Name(DivisionA.Parse(division));
		}

		[Obsolete("defending against old types")]
		static public string Name(DivisionI division)
		{
			return Name(division.ToString());
		}

	}
}
