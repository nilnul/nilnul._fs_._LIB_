using nilnul.exception_;
using nilnul.fs._address._route.division_.div;

namespace nilnul.fs._address.route_
{
	//extern alias bit;
	/// <summary>
	/// deckDocument
	/// </summary>
	public class Sprig1
		: SprigA1

	{
		private nilnul.fs._address._route.division_.div.DntedI _document;

		public override nilnul.fs._address._route.division_.div.DntedI denotation
		{
			get { return _document; }
		}



		public Sprig1(
			nilnul.fs._address._route.division_.div.DntedI document
		)
		{
			_document = document;
		}

		public Sprig1(Dnted dnted):this( (DntedI)(dnted))
		{
		}

		public override string ToString()
		{
			return $"{nilnul.fs._address.Deck.ToTxt()}{_document}";
		}






		static public Sprig1 Parse(string txt)
		{
			new /*bit::*/nilnul.bit.vow_.True1<ParseException>(new ParseException("not starting with deck(\\ or /)")).vow
			//nilnul.obj.vow_.True.Vow
			(
				txt.StartsWith("\\") || txt.StartsWith("/")
			);


			return new Sprig1(
				nilnul.fs._address._route.division_.div.Dnted .Parse(
					txt.Substring(1)
				)
			);

		}

	}
}
