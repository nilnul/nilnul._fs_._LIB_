using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.fs._address.div._parse
{
	public class Be
		: nilnul.txt.BeI
	{

		/// <summary>
		/// a/b/c/ will be split as a, b, c, ""
		/// </summary>
		/// <param name="splitResult_started"></param>
		/// <returns></returns>
		public bool _ofSlited(IEnumerable<string> splitResult_started)
		{
			if (splitResult_started.Last() != "")
			{
				return false;
			}
			return  nilnul.obj.str_.started.cast_._DetipX._Detip_ofStarted(splitResult_started).All(
				x=> _address.dir._parse.Be.Singleton.be(x)
				
			);
			
		}

		public bool be(string x)
		{
			return _ofSlited(Regex.Split(x, @"(?<=\\)|(?<=\/)").ToArray());
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
