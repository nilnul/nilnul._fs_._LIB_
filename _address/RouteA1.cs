using System.Linq;

namespace nilnul.fs._address
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks> 
	/// alias: path
	/// </remarks>
	/// 
	public abstract class RouteA1
	{

#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public RouteI1 Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		{
			return Parse(s.processed);

		}
		/// <summary>
		/// note, there may be spaces on both ends
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		/// 


		/// <summary>
		/// note, there may be spaces on both ends
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public RouteI1 Parse(string s)
		{
			if (nilnul.seq.be_._NoneX1.Be(s))
			{
				throw new nilnul.obj_.xpn_.ParseException(
					$@"{s} is empty."
				);
			}
			try
			{
				Deck.Vow(s.First());

			}
			catch (nilnul.obj_.xpn_.UnacceptableException)
			{

				throw new nilnul.obj_.xpn_.ParseException($"{s.First()} is not directory separator");
			}

			var division = _address._route.DivisionA.Parse(s.Substring(1));
			switch (division)
			{
				case _address._route.division_. DivI div:
					return new route_.Stem1(div);
				case _address._route.division_.div.DntedI  document:
					return new route_.Sprig1(document);

				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

			//Deck.Vow(s.First());
			//var division = DivisionX.Parse(s.Substring(1));
			//if (division is DivI)
			//{
			//	return new route_.Stem((DivI)division);
			//}


			//return  new route_.sprig_.DeckDocument( (DocumentI1)division   )
			;




		}

		static public RouteI1 Of(nilnul.fs._address._route.DivisionI division)
		{
			switch (division)
			{
				case nilnul.fs._address._route.division_.DivI div:
					return new nilnul.fs._address.route_.Stem1(div);
				case nilnul.fs._address._route.division_.div.DntedI document:
					return new nilnul.fs._address.route_.Sprig1(document);

				default:
					return Of(_route.DivisionA.Parse(division.ToString()));
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}






	}
}
