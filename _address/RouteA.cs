using System;
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
	[Obsolete()]
	public abstract class RouteA
	{

#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public RouteI Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
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
		static public RouteI Parse(string s)
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

			var division = DivisionA.Parse(s.Substring(1));
			switch (division)
			{
				case DivI div:
					return new route_.Stem(div);
				case DocumentI document:
					return new route_.Sprig(document);

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

		static public RouteI Ov(nilnul.fs._address.DivisionI division)
		{
			switch (division)
			{
				case nilnul.fs._address.DivI div:
					return new nilnul.fs._address.route_.Stem(div);
				case nilnul.fs._address.DocumentI document:
					return new nilnul.fs._address.route_.Sprig(document);

				default:
					return Ov(DivisionA.Parse(division.ToString()));
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}






	}
}
