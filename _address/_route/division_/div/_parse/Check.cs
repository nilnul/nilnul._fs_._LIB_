using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs._address.div._parse
{
	public class Check
		: nilnul.obj._parse.CheckI
	{

		public string _check_ofSplited(IEnumerable<string> splitResult_started)
		{
			if (splitResult_started.Last() != "")
			{
				return "the last segment must be empty";
			}
			var checks = (splitResult_started).Take(splitResult_started.Count() - 1).Select(
				(y, i) => new Tuple<int, string>(i, _address.dir._parse.Check.Singleton.check(y))
			);
			var checkNonEmptyS = checks.Where(x => x.Item2 != "");
			if (checkNonEmptyS.Any())
			{
				return $"errors in segs: {string.Join(";", checkNonEmptyS.Select(c => $"第{c.Item1}个目录{checks.ElementAt(c.Item1)}错误:{c.Item2}"))}";
			}
			return "";
		}

		public string check(string x)
		{
			var splitResult = Regex.Split(x, @"(?<=\\)|(?<=\/)").ToArray();

			return _check_ofSplited(splitResult);
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
