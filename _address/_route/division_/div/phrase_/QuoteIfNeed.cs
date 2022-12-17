using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.phrase_
{
	public class QuoteIfNeed : nilnul.obj.PhraseI<nilnul.fs._address.DivI>
	{
		public string phrase(DivI obj)
		{
			return nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op(obj.ToString());
		}


		static public QuoteIfNeed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<QuoteIfNeed>.Instance;
			}
		}

	}
}
