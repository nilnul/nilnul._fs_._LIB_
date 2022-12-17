using System;
using System.Linq;

namespace nilnul.fs._address._dst._denote.txt._compile
{
	static public class _CheckX
	{
		static public string Check(string s)
		{
			if (s == "")
			{
				return _address._route.division_._div._dir._dnt.txt._compile. _check.Resource1.required;
			}
			var r = s.Select((e, i) => new Tuple<char, int>(e, i)).Aggregate(
				""
				,
				(a, c) => a + (nilnul.fs._address._dst._denote.txt.be_._valid.cha.Be.Singleton.be(c.Item1) ? "" : $", 第{c.Item2}个字符{c.Item1}不被允许"
				)
			);
			if (r != "")
			{
				return r;
			}
			if (_dst._denote.txt.be_._valid.InvalidNames.Singleton.contain(s))
			{
				return "保留";
			}
			return "";

		}
	}
}
