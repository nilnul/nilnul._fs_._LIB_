using System;

namespace nilnul.fs._address.document._parse
{

	/// <summary>
	/// div and doc
	/// </summary>
	public class Be
		:
		nilnul.txt.BeI
	{
		public Tuple<string, string> dichotomy(string s)
		{
			var lastIndex = s.LastIndexOfAny(nilnul.characters_.DirSeperator.Chars);
			if (lastIndex < 0)
			{
				return new Tuple<string, string>("", s);
			}
			lastIndex++;
			return new Tuple<string, string>(s.Substring(0, lastIndex), s.Substring(lastIndex));
		}

		public bool be(Tuple<string, string> div)
		{
			return be(div.Item1, div.Item2);
		}
		public bool be(string txt)
		{
			return be(dichotomy(txt));

		}
		public bool be(string div, string doc)
		{

			return  fs._address.div._parse.Be.Singleton.be(
				div
			) && nilnul.fs._address._doc.txt.Be.Singleton.be(
				(doc)
			);
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}
	}
}
