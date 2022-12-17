using System;

namespace nilnul.fs._address
{

	/// <summary>
	/// the inital "/" is optional.
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(fs._address.division.co._duct.IPass)"/>
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.fs.path_.contextual_.ILiteral))]
	public interface IDivision0Route: _address.division.co._duct.pass_.IForward
	{


	}


	[Obsolete(nameof(nilnul.fs.path_.contextual_.ILiteral))]
	static public class Division0RouteX
	{
		static public IDivision0Route Parse(string x) {
			if (nilnul.txt.be_.fs_.BeginWithSep.Singleton.be(x) )
			{
				return RouteA.Parse(x);
			}
			else
			{
				return _address.DivisionA.Parse(x);
			}
		}

		static public DivisionI GetDivision(IDivision0Route x) {
			switch (x)
			{
				case RouteI route:
					return route.division;
				case DivisionI division:
					return division;
				default:
					throw new UnexpectedTypeException($"{x} is neither {nameof(RouteI)} nor {nameof(DivisionI)}");
					break;
			}
		}


		static public DivisionI GetDivision(string x) {
			return GetDivision(Parse(x));
		}



	}
}
