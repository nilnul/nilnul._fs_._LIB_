using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.eq_.fs_.backslashed_
{
	public class EnsureEndDeck : nilnul.txt.eq_.homo_.EqDefaultOvCaseInsensitive
	{
		public EnsureEndDeck() : base(
			 nilnul.txt.op_.unary_.fs_.backslashed_.EndWithDeck.Singleton.op
		)
		{
		}


		static public EnsureEndDeck Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EnsureEndDeck>.Instance;
			}
		}

	}
}
