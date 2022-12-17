﻿using nilnul.exception_;
using nilnul.fs._address._route.division_.div;
using System;

namespace nilnul.fs._address.route_
{
	//extern alias bit;
	/// <summary>
	/// deckDocument
	/// </summary>
	///
	[Obsolete()]
	public class Sprig
		: SprigA

	{
		private nilnul.fs._address.DocumentI _document;

		public override nilnul.fs._address.DocumentI document
		{
			get { return _document; }
		}



		public Sprig(
			nilnul.fs._address.DocumentI document
		)
		{
			_document = document;
		}

		public Sprig(Dnted dnted):this( _address._route.division_.div.dnted._RegressionsX.ToDocument(dnted))
		{
		}

		public override string ToString()
		{
			return $"{nilnul.fs._address.Deck.ToTxt()}{_document}";
		}






		static public Sprig Parse(string txt)
		{
			new /*bit::*/nilnul.bit.vow_.True1<ParseException>(new ParseException("not starting with deck(\\ or /)")).vow
			//nilnul.obj.vow_.True.Vow
			(
				txt.StartsWith("\\") || txt.StartsWith("/")
			);


			return new Sprig(
				nilnul.fs._address.Document.Parse(
					txt.Substring(1)
				)
			);

		}

	}
}
