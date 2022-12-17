using System;

namespace nilnul.fs._address.document._parse
{

	/// <summary>
	/// div and doc
	/// </summary>
	public class Check
		:
		nilnul.obj._parse.CheckI
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

		public string check(Tuple<string, string> div)
		{
			return check(div.Item1, div.Item2);
		}
		public string check(string txt)
		{
			return check(dichotomy(txt));

		}
		public string check(string div, string doc)
		{

			var divCheck = fs._address.div._parse.Check.Singleton.check(
				div
			);

			if (divCheck != "")
			{
				return $"the parent container checked err:{divCheck}";
			}

			var docCheck = nilnul.fs._address.doc._parse._CheckX.Check(
				(doc)
			);

			if (docCheck != "")
			{
				return $"the doc checked err:{docCheck}";
			}
			return "";

		}


		static public Check Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Check>.Instance;
			}
		}





	}
}
