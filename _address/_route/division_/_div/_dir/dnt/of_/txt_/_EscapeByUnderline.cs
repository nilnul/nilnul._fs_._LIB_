using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.denote.of_.txt_
{
	public class EscByUnderline :nilnul.txt.esc_.shrinkAlphabet_.quoteCodepoint_.Undeline
	{
		public EscByUnderline() : base(fs._address._dst._denote.txt.be_._valid.cha_.Invalids.Singleton.contain)
		{
		}


		public string of(string s) {

			var r= _trailingDots( this.escape(s.Trim()) );

			if (r=="")
			{
				return "__";
			}
			return r;
		}

		/// <summary>
		/// trailing dots will be removed by WindowsOs
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public string _trailingDots(string s) {
			var trailingNils= s.Reverse().TakeWhile( c=>c=='.'

			);

			var dotsCount = trailingNils.Count();
			return s.Substring(
					0
					,
					s.Length - dotsCount
				)
				+
				nilnul.txt.op_.unary_.RepeatX.Repeat(
					nilnul.txt.esc_.shrinkAlphabet_._CodepointX._Escape('_', '.')
					,
					dotsCount
				)
			;
		}

		static public EscByUnderline Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EscByUnderline>.Instance;
			}
		}

	}
}
