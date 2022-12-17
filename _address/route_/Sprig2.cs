using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.route_.deckedDocument_;

namespace nilnul.fs._address.route_
{
	[Obsolete()]
	public class Sprig2
		:SprigA

	{
		private nilnul.fs._address.DocumentI2 _document;

		public override  nilnul.fs._address.DocumentI2 document
		{
			 get { return _document; }
		}

		

		public Sprig2(
			nilnul.fs._address.DocumentI2 document
		)
		{
			_document = document;
		}

		public override string ToString()
		{
			return $"{nilnul.fs._address.Deck.ToTxt()}{_document}";
		}

		


		

		static public Sprig2 Parse(string txt)
		{

			nilnul.obj.vow_.True.Vow(
				txt.StartsWith("\\") || txt.StartsWith("/")
			);


			return new Sprig2(
				nilnul.fs._address.Document2.Parse(
					txt.Substring(1)
				)
			);

		}

	}
}
